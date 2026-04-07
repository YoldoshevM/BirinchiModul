using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

class Program
{
    static List<RozaKuni> Ramazon = new List<RozaKuni>()
    {
        new RozaKuni(1, "05:10", "18:45"),
        new RozaKuni(2, "05:09", "18:46"),
        new RozaKuni(3, "05:08", "18:47"),
        new RozaKuni(4, "05:07", "18:48"),
        new RozaKuni(5, "05:06", "18:49"),
        new RozaKuni(6, "05:05", "18:50"),
        new RozaKuni(7, "05:04", "18:51"),
        new RozaKuni(8, "05:03", "18:52"),
        new RozaKuni(9, "05:02", "18:53"),
        new RozaKuni(10, "05:01", "18:54"),
        new RozaKuni(11, "05:00", "18:55"),
        new RozaKuni(12, "04:59", "18:56"),
        new RozaKuni(13, "04:58", "18:57"),
        new RozaKuni(14, "04:57", "18:58"),
        new RozaKuni(15, "04:56", "18:59"),
        new RozaKuni(16, "04:55", "19:00"),
        new RozaKuni(17, "04:54", "19:01"),
        new RozaKuni(18, "04:53", "19:02"),
        new RozaKuni(19, "04:52", "19:03"),
        new RozaKuni(20, "04:51", "19:04"),
        new RozaKuni(21, "04:50", "19:05"),
        new RozaKuni(22, "04:49", "19:06"),
        new RozaKuni(23, "04:48", "19:07"),
        new RozaKuni(24, "04:47", "19:08"),
        new RozaKuni(25, "04:46", "19:09"),
        new RozaKuni(26, "04:45", "19:10"),
        new RozaKuni(27, "04:44", "19:11"),
        new RozaKuni(28, "04:43", "19:12"),
        new RozaKuni(29, "04:42", "19:13"),
        new RozaKuni(30, "04:41", "19:14"),
    };

    static string SaharDuo = "Niyat qildim ro‘za tutmoqqa, Ramazon oyining farz ro‘zasini...";
    static string IftarDuo = "Allohumma laka sumtu va bika aamantu va ‘alayka tavakkaltu...";
    static Dictionary<long, int> LastMessage = new Dictionary<long, int>();


    static async Task Main()
    {
        var bot = new TelegramBotClient("8568956114:AAG9JOF-UTl5MQ3uGd20lMeXtTVgjgGi73U");

        static Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken ct)
        {
            Console.WriteLine(exception.ToString());
            return Task.CompletedTask;
        }


        Console.WriteLine("Bot ishlayapti...");
        Console.ReadLine();
    }

    static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken ct)
    {
        // /start
        if (update.Message?.Text == "/start")
        {
            var msg = await bot.SendMessage(
                update.Message.Chat.Id,
                "📅 Ramazon kunini tanlang:",
                replyMarkup: GetButtons(),
                cancellationToken: ct
            );

            LastMessage[update.Message.Chat.Id] = msg.MessageId;
        }


        // button bosilganda
        if (update.CallbackQuery != null)
        {
            var chatId = update.CallbackQuery.Message.Chat.Id;
            var data = update.CallbackQuery.Data;

            if (data.StartsWith("day_"))
            {
                int kun = int.Parse(data.Split('_')[1]);
                var info = Ramazon.First(x => x.Kun == kun);

                string text =
        $@"📅 {kun}-kun

🌙 Saharlik: {info.Saharlik}
🌇 Iftorlik: {info.Iftorlik}

🤲 Sahar duosi:
{SaharDuo}

🤲 Iftar duosi:
{IftarDuo}";

                // eski message o‘chirish
                if (LastMessage.ContainsKey(chatId))
                {
                    try
                    {
                        await bot.DeleteMessage(chatId, LastMessage[chatId]);
                    }
                    catch { }
                }

                // yangi message
                var newMsg = await bot.SendMessage(
                    chatId: chatId,
                    text: text,
                    replyMarkup: GetButtons(),
                    cancellationToken: ct
                );

                // saqlash
                LastMessage[chatId] = newMsg.MessageId;
            }
        }


        static Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken ct)
        {
            Console.WriteLine(exception.ToString());
            return Task.CompletedTask;
        }

        // BUTTONLAR
        static InlineKeyboardMarkup GetButtons()
        {
            var keyboard = new List<List<InlineKeyboardButton>>();
            var row = new List<InlineKeyboardButton>();

            foreach (var x in Ramazon)
            {
                row.Add(InlineKeyboardButton.WithCallbackData($"{x.Kun}-kun", $"day_{x.Kun}"));

                if (row.Count == 5)
                {
                    keyboard.Add(new List<InlineKeyboardButton>(row));
                    row.Clear();
                }
            }

            if (row.Count > 0)
                keyboard.Add(row);

            return new InlineKeyboardMarkup(keyboard);
        }
    }

    // MODEL
    class RozaKuni
    {
        public int Kun { get; set; }
        public string Saharlik { get; set; }
        public string Iftorlik { get; set; }

        public RozaKuni(int kun, string sahar, string iftor)
        {
            Kun = kun;
            Saharlik = sahar;
            Iftorlik = iftor;
        }
    }
}
