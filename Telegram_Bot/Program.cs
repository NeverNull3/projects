using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_Bot
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("6024324373:AAFLu5Xcs1mjgBpaYQU_fBHWjV5xWpLJiLo");

            client.StartReceiving(Update, Error);
            
            Console.ReadLine();
   
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            
            var message = update.Message;
            
            var chatid = message.Chat.Id;
            
            
             


            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("купить приколы"))
                { 
                    var text = "ПРИКОЛЬЧИКИ:))";

                     var ikm = new InlineKeyboardMarkup(new[]
                     {
                          new[]
                          {
                            InlineKeyboardButton.WithUrl("КУПИТЬ МЕФ - 2200грн/1г", "https://mvs.gov.ua/"),
                          },
                          new[]
                          {
                             InlineKeyboardButton.WithUrl("КУПИТЬ ШИШ - 1150грн/1г", "https://cmhmda.org.ua/home/news/monitoryng-narkotychnoyi-sytuacziyi-v-ukrayini/normatyvna-baza-shhodo-narkotykiv/kryminalnyj-kodeks-ukrayiny-obig-narkotykiv/"),
                          },

                     });
                    
                    
                    await botClient.SendTextMessageAsync(chatid, text, replyMarkup: ikm, cancellationToken: token);


                    Message photo = await botClient.SendPhotoAsync(
                    chatId: chatid,
                    photo: InputFile.FromUri("https://www.google.com/imgres?imgurl=https%3A%2F%2Fsteamuserimages-a.akamaihd.net%2Fugc%2F860614665748318196%2F73F72BEE27FB238933BE4E949CA75C6F8A6E7662%2F%3Fimw%3D637%26imh%3D358%26ima%3Dfit%26impolicy%3DLetterbox%26imcolor%3D%2523000000%26letterbox%3Dtrue&tbnid=fdhSQSnFRTNCbM&vet=12ahUKEwiWs__rjJr_AhX9isMKHUkUCjMQMygCegQIARA7..i&imgrefurl=https%3A%2F%2Fsteamcommunity.com%2Fsharedfiles%2Ffiledetails%2F%3Fid%3D1215794690&docid=dSQSOhYSwtiy1M&w=637&h=358&q=%D1%81%D0%BA%D1%80%D0%B8%D0%BC%D0%B5%D1%80%20%D1%81%20%D1%83%D1%80%D0%BB&hl=uk&ved=2ahUKEwiWs__rjJr_AhX9isMKHUkUCjMQMygCegQIARA7"),
                     
                     parseMode: ParseMode.Html,
                     cancellationToken: token);

                    Thread.Sleep(5000);
                     
                     Message location = await botClient.SendLocationAsync(
                     chatId: chatid,
                     latitude: 51.50551f,
                     longitude: 31.28487f,
                     cancellationToken: token);
                }
                

                Console.WriteLine($"{message.Chat.Username}  |  {message.Text}");
                
                

            }



        }
        

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}
