using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Telegram_bot
{
    class Program
    {
        private static string Token { get; set; } = "2096779250:AAGLwigmPaI03HeU2Fd2Lbgm0NNFUPxkiEg";
        private static TelegramBotClient client;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(Token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null)
            {

                await client.SendTextMessageAsync(msg.Chat.Id, msg.Text );
            }
        }

    }
}
