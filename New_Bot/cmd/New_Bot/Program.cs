using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

var botClient = new TelegramBotClient("8104930850:AAE4U9CzmBZQrFW-CHOzvbSRqy62pMpz8yA");
using var cts = new CancellationTokenSource();

// Har bir foydalanuvchi uchun tilni saqlash
var userLanguages = new Dictionary<long, string>();

botClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, cancellationToken: cts.Token);
Console.WriteLine("Bot ishga tushdi...");
Console.ReadLine();

async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken token)
{
    // CallbackQuery (inline tugmalar bosilganda)
    if (update.CallbackQuery is { } callback)
    {
        var callbackChatId = callback.Message.Chat.Id;
        var data = callback.Data;

        // Til tanlash
        if (data == "lang_uz" || data == "lang_ru" || data == "lang_en")
        {
            userLanguages[callbackChatId] = data;
            await client.AnswerCallbackQuery(callback.Id);

            string msg = data == "lang_uz" ? "✅ O'zbek tili tanlandi!" :
                         data == "lang_ru" ? "✅ Русский язык выбран!" :
                         "✅ English selected!";

            await client.SendMessage(callbackChatId, msg);
            await ShowMainMenu(client, callbackChatId, data);
            return;
        }

        // Kater navigatsiyasi
        if (data == "prev_kater")
        {
            await client.AnswerCallbackQuery(callback.Id, GetText("prev_kater_alert", userLanguages.GetValueOrDefault(callbackChatId, "lang_uz")), true);
        }
        else if (data == "next_kater")
        {
            // Hozirgi katerni bilish uchun (xabar matniga qarab)
            var msgText = callback.Message.Text;
            bool isKater1 = msgText.Contains("Kater #1") || msgText.Contains("Катер #1") || msgText.Contains("Boat #1");

            if (isKater1)
            {
                await ShowKater2(client, callbackChatId, userLanguages.GetValueOrDefault(callbackChatId, "lang_uz"));
            }
            else
            {
                await client.AnswerCallbackQuery(callback.Id, GetText("no_more_boats", userLanguages.GetValueOrDefault(callbackChatId, "lang_uz")), true);
            }
        }
        else if (data == "prev_kater2")
        {
            await ShowKater1(client, callbackChatId, userLanguages.GetValueOrDefault(callbackChatId, "lang_uz"));
        }
        else if (data == "kater1_location")
        {
            await client.SendLocation(callbackChatId, 41.2995, 69.2401);
        }
        else if (data == "kater2_location")
        {
            await client.SendLocation(callbackChatId, 41.3050, 69.2450);
        }
        await client.AnswerCallbackQuery(callback.Id);
        return;
    }

    // Oddiy xabarlar
    if (update.Message is not { } message)
        return;

    var chatId = message.Chat.Id;
    var text = message.Text;

    // /start komandasi
    if (text == "/start")
    {
        await ShowLanguageMenu(client, chatId);
        return;
    }

    // Tilni tekshirish (hali tanlamagan bo'lsa)
    if (!userLanguages.ContainsKey(chatId))
    {
        await ShowLanguageMenu(client, chatId);
        return;
    }

    var lang = userLanguages[chatId];

    // Menyu tugmalari
    if (text == GetText("btn_boats", lang))
    {
        await ShowKater1(client, chatId, lang);
    }
    else if (text == GetText("btn_location", lang))
    {
        await ShowLocation(client, chatId, lang);
    }
    else if (text == GetText("btn_instagram", lang))
    {
        await ShowInstagram(client, chatId, lang);
    }
    else if (text == GetText("btn_contact", lang))
    {
        await ShowContact(client, chatId, lang);
    }
    else
    {
        await client.SendMessage(chatId, GetText("unknown_command", lang), parseMode: ParseMode.Markdown);
    }
}

// Til tanlash menyusi
async Task ShowLanguageMenu(ITelegramBotClient client, long chatId)
{
    var inlineKeyboard = new InlineKeyboardMarkup(new[]
    {
        new[] { InlineKeyboardButton.WithCallbackData("🇺🇿 O'zbek tili", "lang_uz") },
        new[] { InlineKeyboardButton.WithCallbackData("🇷🇺 Русский язык", "lang_ru") },
        new[] { InlineKeyboardButton.WithCallbackData("🇬🇧 English", "lang_en") }
    });

    await client.SendMessage(
        chatId: chatId,
        text: "🌍 *Tilni tanlang / Выберите язык / Choose language:*",
        parseMode: ParseMode.Markdown,
        replyMarkup: inlineKeyboard);
}

// Asosiy menyu
async Task ShowMainMenu(ITelegramBotClient client, long chatId, string lang)
{
    var replyKeyboard = new ReplyKeyboardMarkup(new[]
    {
        new[] { new KeyboardButton(GetText("btn_boats", lang)) },
        new[] { new KeyboardButton(GetText("btn_location", lang)) },
        new[] { new KeyboardButton(GetText("btn_instagram", lang)), new KeyboardButton(GetText("btn_contact", lang)) }
    })
    {
        ResizeKeyboard = true,
        OneTimeKeyboard = false
    };

    await client.SendMessage(
        chatId: chatId,
        text: GetText("welcome", lang),
        parseMode: ParseMode.Markdown,
        replyMarkup: replyKeyboard);
}

// Kater #1
async Task ShowKater1(ITelegramBotClient client, long chatId, string lang)
{
    var inlineButtons = new InlineKeyboardMarkup(new[]
    {
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_prev", lang), "prev_kater") },
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_next", lang), "next_kater") },
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_show_location", lang), "kater1_location") },
        new[] { InlineKeyboardButton.WithUrl(GetText("btn_google_maps", lang), "https://maps.google.com/?q=41.2995,69.2401") }
    });

    await client.SendMessage(
        chatId: chatId,
        text: GetText("kater1_text", lang),
        parseMode: ParseMode.Markdown,
        replyMarkup: inlineButtons);
}

// Kater #2 (Oldingi tugmasi bilan)
async Task ShowKater2(ITelegramBotClient client, long chatId, string lang)
{
    var inlineButtons = new InlineKeyboardMarkup(new[]
    {
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_prev_kater2", lang), "prev_kater2") },
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_next", lang), "next_kater") },
        new[] { InlineKeyboardButton.WithCallbackData(GetText("btn_show_location", lang), "kater2_location") },
        new[] { InlineKeyboardButton.WithUrl(GetText("btn_google_maps", lang), "https://maps.google.com/?q=41.3050,69.2450") }
    });

    await client.SendMessage(
        chatId: chatId,
        text: GetText("kater2_text", lang),
        parseMode: ParseMode.Markdown,
        replyMarkup: inlineButtons);
}

// Lokatsiyani ko'rish
async Task ShowLocation(ITelegramBotClient client, long chatId, string lang)
{
    var locationButtons = new InlineKeyboardMarkup(new[]
    {
        new[] { InlineKeyboardButton.WithUrl(GetText("btn_google_maps", lang), "https://maps.google.com/?q=41.2995,69.2401") }
    });

    await client.SendLocation(chatId, 41.2995, 69.2401);
    await client.SendMessage(chatId, GetText("location_text", lang), parseMode: ParseMode.Markdown, replyMarkup: locationButtons);
}

// Instagram
async Task ShowInstagram(ITelegramBotClient client, long chatId, string lang)
{
    try
    {
        var instaButton = new InlineKeyboardMarkup(InlineKeyboardButton.WithUrl("📱 Instagram", "https://www.instagram.com/__yoldowev/"));
        await client.SendMessage(chatId, GetText("instagram_text", lang), parseMode: ParseMode.Markdown, replyMarkup: instaButton);
    }
    catch (Exception)
    {
        await client.SendMessage(chatId, GetText("instagram_text", lang) + "\n\nhttps://www.instagram.com/__yoldowev/", parseMode: ParseMode.Markdown);
    }
}

// Aloqa
async Task ShowContact(ITelegramBotClient client, long chatId, string lang)
{
    await client.SendMessage(chatId, GetText("contact_text", lang), parseMode: ParseMode.Markdown);
}

// MATNLAR (3 tilda)
string GetText(string key, string lang)
{
    var texts = new Dictionary<string, Dictionary<string, string>>
    {
        ["welcome"] = new()
        {
            ["lang_uz"] = "✨ *Assalomu alaykum! Daryo Katerlari Botiga Xush Kelibsiz!* ✨\n\n🚤 *Katerlar* – narx va joylashuv\n📍 *Lokatsiyani ko'rish* – kater joylashuvi\n📸 *Instagram* – bizning sahifamiz\n📞 *Aloqa* – tez yordam",
            ["lang_ru"] = "✨ *Добро пожаловать в бот речных катеров!* ✨\n\n🚤 *Катера* – цена и расположение\n📍 *Посмотреть локацию* – расположение катера\n📸 *Instagram* – наша страница\n📞 *Контакты* – быстрая помощь",
            ["lang_en"] = "✨ *Welcome to the River Boats Bot!* ✨\n\n🚤 *Boats* – price and location\n📍 *View location* – boat location\n📸 *Instagram* – our page\n📞 *Contact* – quick help"
        },
        ["btn_boats"] = new()
        {
            ["lang_uz"] = "🚤 Katerlarni ko'rish",
            ["lang_ru"] = "🚤 Посмотреть катера",
            ["lang_en"] = "🚤 View Boats"
        },
        ["btn_location"] = new()
        {
            ["lang_uz"] = "📍 Lokatsiyani ko'rish",
            ["lang_ru"] = "📍 Посмотреть локацию",
            ["lang_en"] = "📍 View Location"
        },
        ["btn_instagram"] = new()
        {
            ["lang_uz"] = "📸 Instagram",
            ["lang_ru"] = "📸 Instagram",
            ["lang_en"] = "📸 Instagram"
        },
        ["btn_contact"] = new()
        {
            ["lang_uz"] = "📞 Aloqa",
            ["lang_ru"] = "📞 Контакты",
            ["lang_en"] = "📞 Contact"
        },
        ["btn_prev"] = new()
        {
            ["lang_uz"] = "⬅️ Oldingi",
            ["lang_ru"] = "⬅️ Назад",
            ["lang_en"] = "⬅️ Previous"
        },
        ["btn_prev_kater2"] = new()
        {
            ["lang_uz"] = "⬅️ Oldingi",
            ["lang_ru"] = "⬅️ Назад",
            ["lang_en"] = "⬅️ Previous"
        },
        ["btn_next"] = new()
        {
            ["lang_uz"] = "➡️ Keyingi",
            ["lang_ru"] = "➡️ Далее",
            ["lang_en"] = "➡️ Next"
        },
        ["btn_show_location"] = new()
        {
            ["lang_uz"] = "📍 Lokatsiyani ko'rish",
            ["lang_ru"] = "📍 Показать локацию",
            ["lang_en"] = "📍 Show Location"
        },
        ["btn_google_maps"] = new()
        {
            ["lang_uz"] = "🗺 Google Maps",
            ["lang_ru"] = "🗺 Google Maps",
            ["lang_en"] = "🗺 Google Maps"
        },
        ["kater1_text"] = new()
        {
            ["lang_uz"] = "🚤 *Kater #1 – Zarif*\n👥 10 kishilik\n💰 Narxi: 200 000 so'm/soat\n📍 Joylashuv: Daryo bo'yi, 1-chi to'xtash joyi\n📞 +998 90 123 45 67\n\n⭐️ *Mijozlar bahosi:* 4.8/5\n\n(1/2)",
            ["lang_ru"] = "🚤 *Катер #1 – Зариф*\n👥 10 мест\n💰 Цена: 200 000 сум/час\n📍 Расположение: Набережная, 1-я остановка\n📞 +998 90 123 45 67\n\n⭐️ *Оценка клиентов:* 4.8/5\n\n(1/2)",
            ["lang_en"] = "🚤 *Boat #1 – Zarif*\n👥 10 persons\n💰 Price: 200,000 UZS/hour\n📍 Location: Riverside, 1st stop\n📞 +998 90 123 45 67\n\n⭐️ *Customer rating:* 4.8/5\n\n(1/2)"
        },
        ["kater2_text"] = new()
        {
            ["lang_uz"] = "🚤 *Kater #2 – Layner*\n👥 6 kishilik\n💰 Narxi: 150 000 so'm/soat\n📍 Joylashuv: Daryo bo'yi, 2-chi to'xtash joyi\n📞 +998 90 123 45 68\n\n(2/2)",
            ["lang_ru"] = "🚤 *Катер #2 – Лайнер*\n👥 6 мест\n💰 Цена: 150 000 сум/час\n📍 Расположение: Набережная, 2-я остановка\n📞 +998 90 123 45 68\n\n(2/2)",
            ["lang_en"] = "🚤 *Boat #2 – Layner*\n👥 6 persons\n💰 Price: 150,000 UZS/hour\n📍 Location: Riverside, 2nd stop\n📞 +998 90 123 45 68\n\n(2/2)"
        },
        ["location_text"] = new()
        {
            ["lang_uz"] = "📍 *Daryo katerlari joylashuvi*\nManzil: Daryo bo'yi, 1-chi to'xtash joyi",
            ["lang_ru"] = "📍 *Расположение речных катеров*\nАдрес: Набережная, 1-я остановка",
            ["lang_en"] = "📍 *River boats location*\nAddress: Riverside, 1st stop"
        },
        ["instagram_text"] = new()
        {
            ["lang_uz"] = "✨ *Bizning Instagram sahifamiz:*\n👇 Quyidagi tugma orqali o'ting",
            ["lang_ru"] = "✨ *Наша страница в Instagram:*\n👇 Перейдите по кнопке ниже",
            ["lang_en"] = "✨ *Our Instagram page:*\n👇 Click the button below"
        },
        ["contact_text"] = new()
        {
            ["lang_uz"] = "📞 *Biz bilan bog'lanish:*\n\n👨‍💼 *Admin:* +998 90 123 45 67\n⏰ *Ish vaqti:* 09:00 – 22:00\n📍 *Manzil:* Daryo bo'yi, 1-chi to'xtash joyi",
            ["lang_ru"] = "📞 *Свяжитесь с нами:*\n\n👨‍💼 *Админ:* +998 90 123 45 67\n⏰ *Режим работы:* 09:00 – 22:00\n📍 *Адрес:* Набережная, 1-я остановка",
            ["lang_en"] = "📞 *Contact us:*\n\n👨‍💼 *Admin:* +998 90 123 45 67\n⏰ *Working hours:* 09:00 – 22:00\n📍 *Address:* Riverside, 1st stop"
        },
        ["unknown_command"] = new()
        {
            ["lang_uz"] = "❓ *Tushunarsiz buyruq.* /start bosing",
            ["lang_ru"] = "❓ *Неизвестная команда.* Нажмите /start",
            ["lang_en"] = "❓ *Unknown command.* Press /start"
        },
        ["prev_kater_alert"] = new()
        {
            ["lang_uz"] = "Bu birinchi kater",
            ["lang_ru"] = "Это первый катер",
            ["lang_en"] = "This is the first boat"
        },
        ["no_more_boats"] = new()
        {
            ["lang_uz"] = "❌ Boshqa kater mavjud emas",
            ["lang_ru"] = "❌ Больше нет катеров",
            ["lang_en"] = "❌ No more boats available"
        }
    };

    return texts.GetValueOrDefault(key, new Dictionary<string, string>()).GetValueOrDefault(lang, "❓ Xato");
}

async Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken token)
{
    Console.WriteLine($"Xatolik: {exception.Message}");
}