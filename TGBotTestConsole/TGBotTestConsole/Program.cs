using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Telegram.Bot;

namespace TGBotTestConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var botClient = new TelegramBotClient("715929443:AAFsK9aUiSarIl524r57_1TiwwBH093GU_I");

            var me = await botClient.GetMeAsync();
            Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
            Console.ReadLine();
        }
    }
}
