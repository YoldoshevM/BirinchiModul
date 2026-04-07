namespace _4_modul_Exam;


using System.Text.Json;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

class Program
{
    static string token = "8104930850:AAE4U9CzmBZQrFW-CHOzvbSRqy62pMpz8yA";
    static TelegramBotClient bot = new TelegramBotClient(token);

    static async Task Main()
    {
        using var cts = new CancellationTokenSource();

        bot.StartReceiving(HandleUpdate, HandleError, cancellationToken: cts.Token);

        Console.WriteLine("Bot ishlayapti...");
        Console.ReadLine();
    }

    static async Task HandleUpdate(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        if (update.Message is not { } message)
            return;

        var chatId = message.Chat.Id;

        if (message.Text == "/start")
        {
            await botClient.SendMessage(
                chatId,
                "Xush kelibsiz 👋\nBitta Objectni soz korinishida yozing :"
            );
        }
    }

    static async Task<string> GetCurrency(string code)
    {
        using HttpClient client = new HttpClient();

        var url = "https://api.unsplash.com/search/photos";
        var response = await client.GetStringAsync(url);

        var json = JsonDocument.Parse(response);

        foreach (var item in json.RootElement.EnumerateArray())
        {
            if (item.GetProperty("image").GetString() == code)
            {
                return item.GetProperty("Rate").GetString();
            }
        }

        return "Rasim topilmadi ❌";
    }

    static Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken token)
    {
        Console.WriteLine(exception.Message);
        return Task.CompletedTask;
    }

}
