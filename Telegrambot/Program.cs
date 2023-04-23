// dotnet add package Telegram.Bot
using Telegram.Bot;
using Telegram.Bot.Types;

TelegramBotClient client = new TelegramBotClient("6075118055:AAGgpIiOE0iCWDxKYawzMxHjWVBiHPyEoOg");

List<long> users = new List<long>();
long adminId = 0;

DateTime dateAlert = DateTime.Now;

User user = await client.GetMeAsync();

Console.WriteLine(user.Username);

while (true)
{
    Update[] updates = await client.GetUpdatesAsync();

    for (var i = 0; i < updates.Length; i++)
    {
        SendGoose(updates[i]);
        if (updates[i].Message.Text == "123")
        {
            adminId = updates[i].Message.From.Id;
        }

        if (DateTime.TryParse(updates[i].Message.Text, out DateTime date))
        {
            Console.WriteLine(date);
            dateAlert = date;
            SendAlert();
        }

        if (!users.Contains(updates[i].Message.From.Id) && updates[i].Message.From.Id != adminId)
        {
            Console.WriteLine(updates[i].Message.From.Id);
            users.Add(updates[i].Message.From.Id);
        }

        if (adminId == updates[i].Message.From.Id)
        {
            SendMessageToAllUsers(updates[i].Message.Text);
        }
    }

    if (updates.Length != 0)
    {
        updates = await client.GetUpdatesAsync(updates[updates.Length - 1].Id + 1);
    }
}

void SendGoose(Update update)
{
    if (update.Message.Text.ToLower() == "хочу гуся")
    {
        StreamReader reader = new StreamReader("Images/123.jpg");// укажите путь до файла
        client.SendPhotoAsync(update.Message.From.Id, reader.BaseStream);
    }
}

void SendAlert()
{
    Task.Run(() =>
    {
        while (true)
        {
            if (DateTime.Now.AddMinutes(15) == dateAlert)
            {
                SendMessageToAllUsers($"Занятие начнется через {15} минут");
            }

            if (DateTime.Now == dateAlert)
            {
                SendMessageToAllUsers($"Занятие началось, присоединяйтесь.");
                return;
            }
        }
    });
}

void SendMessageToAllUsers(string text)
{
    for (int i = 0; i < users.Count; i++)
    {
        client.SendTextMessageAsync(new ChatId(users[i]), text);
    }
}