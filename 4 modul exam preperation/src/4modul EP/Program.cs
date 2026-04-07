
/////////////////////////////////////////////////







//using System.Text.Json;
//using Telegram.Bot;
//using Telegram.Bot.Types;
//using Telegram.Bot.Types.ReplyMarkups;

//class Program
//{
//    static string token = "8104930850:AAE4U9CzmBZQrFW-CHOzvbSRqy62pMpz8yA";
//    static TelegramBotClient bot = new TelegramBotClient(token);

//    static async Task Main()
//    {
//        using var cts = new CancellationTokenSource();

//        bot.StartReceiving(HandleUpdate, HandleError, cancellationToken: cts.Token);

//        Console.WriteLine("Bot ishlayapti...");
//        Console.ReadLine();
//    }

//    static async Task HandleUpdate(ITelegramBotClient botClient, Update update, CancellationToken token)
//    {
//        if (update.Message is not { } message)
//            return;

//        var chatId = message.Chat.Id;

//        if (message.Text == "/start")
//        {
//            var keyboard = new ReplyKeyboardMarkup(new[]
//            {
//                new KeyboardButton[] { "USD", "EUR" },
//                new KeyboardButton[] { "RUB", "GBP" }
//            })
//            {
//                ResizeKeyboard = true
//            };

//            await botClient.SendMessage(
//                chatId,
//                "Xush kelibsiz 👋\nValyutani tanlang:",
//                replyMarkup: keyboard
//            );
//        }
//        else
//        {
//            string currency = message.Text;

//            var rate = await GetCurrency(currency);

//            await botClient.SendMessage(
//                chatId,
//                $"{currency} kursi: {rate} so'm 💰"
//            );
//        }
//    }

//    static async Task<string> GetCurrency(string code)
//    {
//        using HttpClient client = new HttpClient();

//        var url = "https://cbu.uz/uz/arkhiv-kursov-valyut/json/";
//        var response = await client.GetStringAsync(url);

//        var json = JsonDocument.Parse(response);

//        foreach (var item in json.RootElement.EnumerateArray())
//        {
//            if (item.GetProperty("Ccy").GetString() == code)
//            {
//                return item.GetProperty("Rate").GetString();
//            }
//        }

//        return "Topilmadi ❌";
//    }

//    static Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken token)
//    {
//        Console.WriteLine(exception.Message);
//        return Task.CompletedTask;
//    }
//}













































/////////////////////////////////////////////////
















//using System;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading;
//using System.Threading.Tasks;
//using Telegram.Bot;
//using Telegram.Bot.Types;
//using Telegram.Bot.Types.ReplyMarkups;

//class Program
//{
//    static string token = "TOKENINGNI_QO'Y";
//    static TelegramBotClient bot = new TelegramBotClient(token);

//    static JsonElement currencies; // GLOBAL

//    static async Task Main()
//    {
//        using var cts = new CancellationTokenSource();

//        // API ni oldindan yuklab olamiz
//        currencies = await LoadData();

//        bot.StartReceiving(HandleUpdate, HandleError, cancellationToken: cts.Token);

//        Console.WriteLine("Bot ishlayapti...");
//        Console.ReadLine();
//    }

//    static async Task<JsonElement> LoadData()
//    {
//        using HttpClient client = new HttpClient();
//        var url = "https://cbu.uz/uz/arkhiv-kursov-valyut/json/";
//        var response = await client.GetStringAsync(url);

//        return JsonDocument.Parse(response).RootElement;
//    }

//    static async Task HandleUpdate(ITelegramBotClient botClient, Update update, CancellationToken token)
//    {
//        if (update.Message is not { } message)
//            return;

//        var chatId = message.Chat.Id;

//        if (message.Text == "/start")
//        {
//            // 🔥 API dan tugma yasaymiz
//            var buttons = new List<KeyboardButton[]>();
//            var row = new List<KeyboardButton>();

//            int count = 0;

//            foreach (var item in currencies.EnumerateArray())
//            {
//                var code = item.GetProperty("Ccy").GetString();

//                row.Add(new KeyboardButton(code));
//                count++;

//                if (count % 3 == 0)
//                {
//                    buttons.Add(row.ToArray());
//                    row = new List<KeyboardButton>();
//                }
//            }

//            if (row.Count > 0)
//                buttons.Add(row.ToArray());

//            var keyboard = new ReplyKeyboardMarkup(buttons)
//            {
//                ResizeKeyboard = true
//            };

//            await botClient.SendTextMessageAsync(
//                chatId,
//                "Valyutani tanlang 👇",
//                replyMarkup: keyboard
//            );
//        }
//        else
//        {
//            foreach (var item in currencies.EnumerateArray())
//            {
//                if (item.GetProperty("Ccy").GetString() == message.Text)
//                {
//                    var id = item.GetProperty("id").GetInt32();
//                    var name = item.GetProperty("CcyNm_UZ").GetString();
//                    var rate = item.GetProperty("Rate").GetString();

//                    await botClient.SendTextMessageAsync(
//                        chatId,
//                        $"🆔 ID: {id}\n" +
//                        $"💱 Code: {message.Text}\n" +
//                        $"📄 Nomi: {name}\n" +
//                        $"💰 Kurs: {rate} so'm"
//                    );
//                    return;
//                }
//            }

//            await botClient.SendTextMessageAsync(chatId, "Valyuta topilmadi ❌");
//        }
//    }

//    static Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken token)
//    {
//        Console.WriteLine(exception.Message);
//        return Task.CompletedTask;
//    }
//}































/////////////////////////////////////////////////











//namespace _4modul_EP;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;
//using Telegram.Bot;
//using Telegram.Bot.Types;
//using Telegram.Bot.Types.Enums;
//using Telegram.Bot.Types.ReplyMarkups;
//using static Telegram.Bot.TelegramBotClient;

//class Program
//{
//    static string token = "8104930850:AAE4U9CzmBZQrFW-CHOzvbSRqy62pMpz8yA";
//    static TelegramBotClient bot = new TelegramBotClient(token);

//    static List<UserModel> users = new();
//    static List<StatModel> stats = new();

//    static string usersFile = "users.json";
//    static string statsFile = "stats.json";

//    static Dictionary<long, bool> waitingRegister = new();

//    static async Task Main()
//    {
//        LoadData();
//        bot.StartReceiving(UpdateHandler, ErrorHandler);
//        Console.ReadLine();
//    }

//    static void LoadData()
//    {
//        if (File.Exists(usersFile))
//            users = JsonSerializer.Deserialize<List<UserModel>>(File.ReadAllText(usersFile)) ?? new();

//        if (File.Exists(statsFile))
//            stats = JsonSerializer.Deserialize<List<StatModel>>(File.ReadAllText(statsFile)) ?? new();
//    }

//    static void SaveUsers() => File.WriteAllText(usersFile, JsonSerializer.Serialize(users));
//    static void SaveStats() => File.WriteAllText(statsFile, JsonSerializer.Serialize(stats));

//    static async Task UpdateHandler(ITelegramBotClient botClient, Update update, System.Threading.CancellationToken token)
//    {
//        try
//        {
//            if (update.Type != UpdateType.Message || update.Message?.Text == null) return;

//            var msg = update.Message;
//            var chatId = msg.Chat.Id;

//            var user = users.FirstOrDefault(x => x.ChatId == chatId);

//            // START
//            if (msg.Text == "/start")
//            {
//                await botClient.SendMessage(chatId, "😊 Xush kelibsiz!");
//                await SendMenu(chatId, user != null);
//                return;
//            }

//            // RO'YXATDAN O'TISH BOSHLASH
//            if (msg.Text == "📝 Ro'yxatdan o'tish")
//            {
//                waitingRegister[chatId] = true;
//                await botClient.SendMessage(chatId,
//@"✍️ Iltimos quyidagi formatda yuboring:
//PhoneNumber = 90-123-45-67
//FirstName = Muhammad
//LastName = Ali (ixtiyoriy)");
//                return;
//            }

//            // REGISTRATSIYA QABUL QILISH
//            if (waitingRegister.ContainsKey(chatId) && waitingRegister[chatId])
//            {
//                try
//                {
//                    var lines = msg.Text.Split('\n', StringSplitOptions.RemoveEmptyEntries);

//                    string phone = lines.FirstOrDefault(x => x.StartsWith("phoneNumber", StringComparison.OrdinalIgnoreCase))
//                                    ?.Split('=')[1].Trim();
//                    string first = lines.FirstOrDefault(x => x.StartsWith("firstName", StringComparison.OrdinalIgnoreCase))
//                                    ?.Split('=')[1].Trim();
//                    string last = lines.FirstOrDefault(x => x.StartsWith("lastName", StringComparison.OrdinalIgnoreCase))
//                                    ?.Split('=')[1].Trim();

//                    if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(first))
//                    {
//                        await botClient.SendMessage(chatId, "❌ Format noto'g'ri. Iltimos, quyidagi shaklda yuboring:\n\nphoneNumber = 90-123-45-67\nfirstName = Muhammad\nlastName = Ali (ixtiyoriy)");
//                        return;
//                    }

//                    // Avvalgi foydalanuvchini o'chiramiz
//                    users.RemoveAll(x => x.ChatId == chatId);

//                    // Yangi foydalanuvchini qo'shamiz
//                    users.Add(new UserModel
//                    {
//                        ChatId = chatId,
//                        Phone = phone,
//                        FirstName = first,
//                        LastName = string.IsNullOrEmpty(last) ? null : last
//                    });

//                    SaveUsers();
//                    waitingRegister.Remove(chatId);

//                    await botClient.SendMessage(chatId, "✅ Muvaffaqiyatli ro'yxatdan o'tdingiz!");
//                    await SendMenu(chatId, true);
//                }
//                catch
//                {
//                    await botClient.SendMessage(chatId, "❌ Format noto'g'ri. Iltimos, yuqoridagi shablon bo'yicha qaytadan yuboring.");
//                }

//                return;
//            }


//            // CHIQISH
//            if (msg.Text == "🚪 Chiqish")
//            {
//                users.RemoveAll(x => x.ChatId == chatId);
//                stats.RemoveAll(x => x.ChatId == chatId);

//                SaveUsers();
//                SaveStats();

//                await botClient.SendMessage(chatId,
//                    "👋 Salomat bo'ling!\n\nValyutani ko'rish uchun qayta ro'yxatdan o'ting.");

//                await SendMenu(chatId, false);
//                return;
//            }

//            // STATISTIKA
//            // STATISTIKA bo‘limidagi tugmalarni ham olib tashlaymiz
//            if (msg.Text == "📊 Statistika")
//            {
//                var userStats = stats
//                    .Where(x => x.ChatId == chatId)
//                    .GroupBy(x => x.Currency)
//                    .Select(g => $"{g.Key} => {g.Sum(x => x.Count)} marta")
//                    .ToList();

//                string text = userStats.Any() ? "📊 Statistikangiz:\n\n" + string.Join("\n", userStats) : "📊 Sizda statistika yo'q";

//                await bot.SendMessage(chatId, text);

//                // ❌ Pastdagi "Menyuga qaytish" tugmasi olib tashlandi
//            }


//            // VALYUTA
//            if (msg.Text == "💱 Valyutalar")
//            {
//                if (user == null)
//                {
//                    await botClient.SendMessage(chatId, "❗️ Avval ro'yxatdan o'ting");
//                    return;
//                }

//                await SendCurrencyMenu(chatId);
//                return;
//            }

//            // TANLANGAN VALYUTA
//            var currencies = await GetAllCurrencies();
//            var selected = currencies.FirstOrDefault(x => x.Ccy == msg.Text);

//            if (selected != null)
//            {
//                await botClient.SendMessage(chatId, $"💰 {selected.Ccy} kursi: {selected.Rate}");
//                AddStat(chatId, selected.Ccy);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }

//    static async Task SendMenu(long chatId, bool isRegistered)
//    {
//        var buttons = new List<List<KeyboardButton>>();

//        if (!isRegistered)
//        {
//            // Ro'yxatdan o'tmagan foydalanuvchi uchun
//            buttons.Add(new List<KeyboardButton>
//        {
//            new KeyboardButton("📝 Ro'yxatdan o'tish")
//        });
//        }
//        else
//        {
//            // Ro'yxatdan o'tgan foydalanuvchi uchun
//            buttons.Add(new List<KeyboardButton>
//        {
//            new KeyboardButton("💱 Valyutalar"),
//            new KeyboardButton("📊 Statistika")
//        });

//            // Doim pastda chiqish tugmasi
//            buttons.Add(new List<KeyboardButton>
//        {
//            new KeyboardButton("🚪 Chiqish")
//        });
//        }

//        var keyboard = new ReplyKeyboardMarkup(buttons)
//        {
//            ResizeKeyboard = true
//        };

//        await bot.SendMessage(chatId, "📋 Menyu:", replyMarkup: keyboard);
//    }


//    static async Task SendCurrencyMenu(long chatId)
//    {
//        var currencies = await GetAllCurrencies();

//        // Valyutalar tugmalari
//        var buttonList = currencies
//            .Where(c => !string.IsNullOrEmpty(c.Ccy))
//            .Select(c => new KeyboardButton(c.Ccy))
//            .Chunk(3)
//            .Select(row => row.ToList())
//            .ToList();

//        // ❌ PASTKI MENYU TUGMASI O‘CHIRILDI
//        var keyboard = new ReplyKeyboardMarkup(buttonList)
//        {
//            ResizeKeyboard = true
//        };

//        await bot.SendMessage(chatId, "💱 Valyutani tanlang:", replyMarkup: keyboard);
//    }


//    static async Task<List<CurrencyModel>> GetAllCurrencies()
//    {
//        try
//        {
//            using var client = new HttpClient();
//            var json = await client.GetStringAsync("https://cbu.uz/uz/arkhiv-kursov-valyut/json/");
//            return JsonSerializer.Deserialize<List<CurrencyModel>>(json) ?? new();
//        }
//        catch
//        {
//            return new();
//        }
//    }

//    static void AddStat(long chatId, string currency)
//    {
//        var today = DateTime.Now.Date;

//        var stat = stats.FirstOrDefault(x => x.ChatId == chatId && x.Currency == currency && x.Date == today);

//        if (stat == null)
//        {
//            stats.Add(new StatModel
//            {
//                ChatId = chatId,
//                Currency = currency,
//                Date = today,
//                Count = 1
//            });
//        }
//        else
//        {
//            stat.Count++;
//        }

//        SaveStats();
//    }

//    static Task ErrorHandler(ITelegramBotClient botClient, Exception exception, System.Threading.CancellationToken token)
//    {
//        Console.WriteLine(exception.Message);
//        return Task.CompletedTask;
//    }
//}

//public class UserModel
//{
//    public long ChatId { get; set; }
//    public string Phone { get; set; }
//    public string FirstName { get; set; }
//    public string? LastName { get; set; }
//}

//public class StatModel
//{
//    public long ChatId { get; set; }
//    public string Currency { get; set; }
//    public DateTime Date { get; set; }
//    public int Count { get; set; }
//}

//public class CurrencyModel
//{
//    public string Ccy { get; set; }
//    public string Rate { get; set; }
//}











































//                             ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


















//using Telegram.Bot;
//using Telegram.Bot.Types;
/////
//using Telegram.Bot.Types;
//using Telegram.Bot.Types.ReplyMarkups;

/////
//                  1.StartReceiving(...)
//                  bot.StartReceiving(HandleUpdate, HandleError);

//                  Vazifasi:

//                  Botni ishga tushiradi
//                  Xabarlarni qabul qilishni boshlaydi

//                  2. HandleUpdate(...)
//                  static async Task HandleUpdate(ITelegramBotClient botClient, Update update, CancellationToken token)

//                  Vazifasi:

//                 Foydalanuvchidan kelgan har bir xabar shu yerga keladi

//                  3. SendTextMessageAsync(...)
//                 await botClient.SendTextMessageAsync(chatId, "Salom");

//                 Vazifasi:

//                 Userga xabar yuboradi

//                 4. ReplyKeyboardMarkup
//                 var keyboard = new ReplyKeyboardMarkup(new[]
//{
//                 new KeyboardButton[] { "USD", "EUR" }
//});

//                 Vazifasi:

//                 Pastda button(tugma) chiqaradi

//                 Bu — imtihondagi ENG MUHIM NARSA

//                 5. KeyboardButton
//                  new KeyboardButton("USD")

//                 Vazifasi:

//                 Bitta tugma yaratadi

//                 6. /start komandasi
//                  if (message.Text == "/start")

//                Vazifasi:

//                Bot ishga tushganda ishlaydi
//                Odatda:

//                  salomlashish
//                  menu chiqarish
//                7. HttpClient
//                  HttpClient client = new HttpClient();

//                Vazifasi:

//                Internetga so‘rov yuboradi (API chaqiradi) 

//                8. GetStringAsync(...)
//                var response = await client.GetStringAsync(url);

//                Vazifasi:

//                API dan JSON data olib keladi

//                9. JsonDocument.Parse(...)
//                var json = JsonDocument.Parse(response);

//                Vazifasi:

//               JSON ni o‘qiydi (parse qiladi)

//               10. GetProperty(...)
//               item.GetProperty("Rate")

//               Vazifasi:

//               JSON ichidan kerakli fieldni oladi

//               11. foreach
//               foreach (var item in data)

//                Vazifasi:

//                Barcha elementlarni aylanish(loop)

//               12. HandleError(...)
//                static Task HandleError(...)

//                Vazifasi:

//                Xatolarni ushlaydi va chiqaradi






