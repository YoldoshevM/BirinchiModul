using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

class Program
{
    // ===== SOZLAMALAR =====
    // BotFather'dan olgan token shu yerga yoziladi
    static readonly string BotToken = "8104930850:AAE4U9CzmBZQrFW-CHOzvbSRqy62pMpz8yA";

    static readonly HttpClient httpClient = new HttpClient();
    // Jamendo API uchun Client ID kerak (https://devportal.jamendo.com da bepul ro'yxatdan o'tib olinadi)
    static readonly string JamendoClientId = "JAMENDO_CLIENT_ID_BU_YERGA";
    static TelegramBotClient botClient = null!;

    // Har bir chat uchun oxirgi qidiruv natijalarini saqlaymiz (xabar ID -> shu xabarga tegishli natijalar)
    static readonly ConcurrentDictionary<string, List<TrackInfo>> SearchCache = new();

    class TrackInfo
    {
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public string Album { get; set; } = "";
        public string CoverUrl { get; set; } = "";
        public string AudioUrl { get; set; } = "";
        public int Duration { get; set; }
    }

    static async Task Main()
    {
        botClient = new TelegramBotClient(BotToken);

        using var cts = new CancellationTokenSource();

        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>() // hamma update turini qabul qiladi
        };

        botClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            errorHandler: HandleErrorAsync,
            receiverOptions: receiverOptions,
            cancellationToken: cts.Token
        );

        var me = await botClient.GetMe();
        Console.WriteLine($"Bot ishga tushdi: @{me.Username}");
        Console.WriteLine("To'xtatish uchun Enter bosing...");
        Console.ReadLine();

        cts.Cancel();
    }

    static async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken ct)
    {
        try
        {
            // ===== Tugma bosilganda (callback query) =====
            if (update.CallbackQuery is { } callback)
            {
                await HandleCallbackAsync(client, callback, ct);
                return;
            }

            if (update.Message is not { } message) return;
            if (message.Text is not { } text) return;

            var chatId = message.Chat.Id;

            // ===== /start komandasi =====
            if (text.Equals("/start", StringComparison.OrdinalIgnoreCase))
            {
                string welcomeText =
                    "🔥 Assalomu alaykum. Botga xush kelibsiz.\n\n" +
                    "Bot orqali quyidagilarni yuklab olishingiz mumkin:\n" +
                    "• Instagram - post va IGTV + audio bilan;\n" +
                    "• TikTok - suv belgisiz video + audio bilan;\n" +
                    "• YouTube - videolar va shorts + audio bilan;\n" +
                    "• Snapchat - suv belgisiz video + audio bilan;\n" +
                    "• Likee - suv belgisiz video + audio bilan;\n" +
                    "• Pinterest - suv belgisiz video va rasmlar;\n" +
                    "• Threads - video va rasmlar + audio bilan;\n\n" +
                    "Shazam funksiya:\n" +
                    "• Qo'shiq nomi yoki ijrochi ismi\n" +
                    "• Qo'shiq matni\n" +
                    "• Ovozli xabar\n" +
                    "• Video\n" +
                    "• Audio\n" +
                    "• Video xabar\n\n" +
                    "✅ Hozircha ishlaydigan funksiya: qo'shiq nomini yoki ijrochi ismini yozing, men topib beraman.";

                await client.SendMessage(chatId, welcomeText, cancellationToken: ct);
                return;
            }

            // ===== Qolgan har qanday matn — qo'shiq qidiruvi sifatida qaraladi =====
            await SearchAndSendSongAsync(client, chatId, text, ct);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Update xatosi: {ex.Message}");
        }
    }

    static async Task SearchAndSendSongAsync(ITelegramBotClient client, long chatId, string query, CancellationToken ct)
    {
        var searchingMsg = await client.SendMessage(chatId, "🔍 Qidirilmoqda...", cancellationToken: ct);

        try
        {
            string url = $"https://api.jamendo.com/v3.0/tracks/?client_id={JamendoClientId}&format=json&limit=10&search={Uri.EscapeDataString(query)}&include=musicinfo";
            var response = await httpClient.GetStringAsync(url, ct);

            using var json = JsonDocument.Parse(response);
            var root = json.RootElement;

            if (!root.TryGetProperty("results", out var data) || data.GetArrayLength() == 0)
            {
                await client.EditMessageText(chatId, searchingMsg.MessageId,
                    "❌ Hech narsa topilmadi. Bu bot faqat ochiq litsenziyali (Creative Commons) musiqalarni topa oladi — mashhur, label musiqalari bu yerda yo'q. Boshqa nom bilan urinib ko'ring.", cancellationToken: ct);
                return;
            }

            // Eng ko'pi bilan 10 ta natijani olamiz
            var tracks = new List<TrackInfo>();
            int count = Math.Min(data.GetArrayLength(), 10);

            for (int i = 0; i < count; i++)
            {
                var item = data[i];
                tracks.Add(new TrackInfo
                {
                    Title = item.GetProperty("name").GetString() ?? "Noma'lum",
                    Artist = item.GetProperty("artist_name").GetString() ?? "Noma'lum",
                    Album = item.TryGetProperty("album_name", out var alb) ? (alb.GetString() ?? "Noma'lum") : "Noma'lum",
                    CoverUrl = item.TryGetProperty("album_image", out var img) ? (img.GetString() ?? "") : "",
                    AudioUrl = item.GetProperty("audio").GetString() ?? "",
                    Duration = item.TryGetProperty("duration", out var dur) ? dur.GetInt32() : 0
                });
            }

            // Natijalar ro'yxatini matn sifatida tuzamiz
            var listText = new System.Text.StringBuilder();
            listText.AppendLine($"🔎 \"{query}\" bo'yicha topilgan natijalar:\n");

            for (int i = 0; i < tracks.Count; i++)
            {
                var t = tracks[i];
                listText.AppendLine($"{i + 1}. {t.Artist} - {t.Title} ({t.Duration / 60}:{t.Duration % 60:D2})");
            }

            // Natijalarni keshga saqlaymiz, kalit = chatId_messageId
            string cacheKey = $"{chatId}_{searchingMsg.MessageId}";
            SearchCache[cacheKey] = tracks;

            // Inline tugmalarni 5 tadan qilib joylashtiramiz (1-5, 6-10)
            var buttonRows = new List<InlineKeyboardButton[]>();
            var row = new List<InlineKeyboardButton>();

            for (int i = 0; i < tracks.Count; i++)
            {
                row.Add(InlineKeyboardButton.WithCallbackData((i + 1).ToString(), $"pick_{cacheKey}_{i}"));
                if (row.Count == 5)
                {
                    buttonRows.Add(row.ToArray());
                    row = new List<InlineKeyboardButton>();
                }
            }
            if (row.Count > 0) buttonRows.Add(row.ToArray());

            var keyboard = new InlineKeyboardMarkup(buttonRows);

            await client.EditMessageText(
                chatId: chatId,
                messageId: searchingMsg.MessageId,
                text: listText.ToString(),
                replyMarkup: keyboard,
                cancellationToken: ct
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Qidiruv xatosi: {ex.Message}");
            await client.EditMessageText(chatId, searchingMsg.MessageId,
                "⚠️ Xatolik yuz berdi. Birozdan keyin qayta urinib ko'ring.", cancellationToken: ct);
        }
    }

    static async Task HandleCallbackAsync(ITelegramBotClient client, CallbackQuery callback, CancellationToken ct)
    {
        try
        {
            string? data = callback.Data;
            if (string.IsNullOrEmpty(data) || !data.StartsWith("pick_"))
            {
                await client.AnswerCallbackQuery(callback.Id, cancellationToken: ct);
                return;
            }

            // format: pick_{chatId}_{messageId}_{index}
            var parts = data.Substring("pick_".Length).Split('_');
            if (parts.Length != 3)
            {
                await client.AnswerCallbackQuery(callback.Id, "Xatolik", cancellationToken: ct);
                return;
            }

            string cacheKey = $"{parts[0]}_{parts[1]}";
            int index = int.Parse(parts[2]);
            long chatId = long.Parse(parts[0]);

            if (!SearchCache.TryGetValue(cacheKey, out var tracks) || index >= tracks.Count)
            {
                await client.AnswerCallbackQuery(callback.Id, "Natija eskirgan, qaytadan qidiring", cancellationToken: ct);
                return;
            }

            await client.AnswerCallbackQuery(callback.Id, "⏳ Yuklanmoqda...", cancellationToken: ct);

            var track = tracks[index];

            string caption =
                $"🎵 *{track.Title}*\n" +
                $"👤 Ijrochi: {track.Artist}\n" +
                $"💿 Albom: {track.Album}\n" +
                $"⏱ Davomiyligi: {track.Duration / 60}:{track.Duration % 60:D2}";

            if (!string.IsNullOrEmpty(track.CoverUrl))
            {
                await client.SendPhoto(
                    chatId: chatId,
                    photo: InputFile.FromUri(track.CoverUrl),
                    caption: caption,
                    parseMode: ParseMode.Markdown,
                    cancellationToken: ct
                );
            }
            else
            {
                await client.SendMessage(chatId, caption, parseMode: ParseMode.Markdown, cancellationToken: ct);
            }

            if (!string.IsNullOrEmpty(track.AudioUrl))
            {
                await client.SendAudio(
                    chatId: chatId,
                    audio: InputFile.FromUri(track.AudioUrl),
                    title: track.Title,
                    performer: track.Artist,
                    cancellationToken: ct
                );
            }
            else
            {
                await client.SendMessage(chatId, "⚠️ Bu qo'shiq uchun audio fayl mavjud emas.", cancellationToken: ct);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Callback xatosi: {ex.Message}");
        }
    }

    static Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken ct)
    {
        Console.WriteLine($"Bot xatosi: {exception.Message}");
        return Task.CompletedTask;
    }
}