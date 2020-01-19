using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace ihelp_telegram_bot
{
    class Program
    {
        //t.me/iHelParentBot
        static private ITelegramBotClient botClient;
        static int scores, questNum;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("949984049:AAEBpdfm6eqdLN6-hbL7ZRvPVRhT2e0AOfk"); // переменная с ботом
            var me = botClient.GetMeAsync().Result; // получение информации о самом себе
            Console.WriteLine(
              $"Hello! I am user {me.Id} and my name is {me.FirstName} username {me.Username}.");

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e) // MessageEventArgs - в подклассе Message вся инфа о сообщении пришедшем из чата
        { // метод как бот реагирует на сообщение пользователя
            if (e.Message.Text == "/start")
                await SendMessage(e.Message.Chat, "Роль родителей в воспитании ребенка незаменима. Они главные «проектировщики," +
                    " конструкторы и строители» детской личности. \n\nТест дополнит Ваше" +
                    " представление о себе как о родителях, поможет сделать определенные выводы" +
                    " относительно проблем воспитания детей." + "\n\n" +
                    " Для того, чтобы начать тест, напиши мне /go");
            else if (e.Message.Text != "/start" && e.Message.Text != "/go" && e.Message.Text != "1" && e.Message.Text != "2" && e.Message.Text != "3")
                await SendMessage(e.Message.Chat, "Я пока не все слова научился понимать. Напиши мне ответ на вопрос или команду.");
            // 1 ВОПРОС
            else if (e.Message.Text == "/go")
            {
                scores = 0;
                questNum = 0;
                await SendMessage(e.Message.Chat, "В тесте всего 13 вопросов. Отвечай цифрами: 1, 2 или 3. После прохождения" +
                    " я пришлю тебе результаты теста.");
                questNum++;
            }
            if (e.Message.Text == "1" || e.Message.Text == "2" || e.Message.Text == "3" || e.Message.Text == "/go")
            {
                // 1 ВОПРОС
                if (e.Message.Text == "/go" && questNum == 1)
                {
                    await SendMessage(e.Message.Chat, "В любой момент оставить все свои дела и заняться ребенком? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 2 ВОПРОС
                else if (questNum == 2)
                {
                    await SendMessage(e.Message.Chat, "Посоветоваться с ребенком, невзирая на его возраст?");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 3 ВОПРОС
                else if (questNum == 3)
                {
                    await SendMessage(e.Message.Chat, "Признаться ребенку в ошибке, совершенной по отношению к нему?");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 4 ВОПРОС
                else if (questNum == 4)
                {
                    await SendMessage(e.Message.Chat, "Извиниться перед ребенком в случае своей неправоты?");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 5 ВОПРОС
                else if (questNum == 5)
                {
                    await SendMessage(e.Message.Chat, "Сохранить самообладание, даже если поступок ребенка вывел Вас из себя?");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 6 ВОПРОС
                else if ( questNum == 6)
                {
                    await SendMessage(e.Message.Chat, "Поставить себя на место ребенка?");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 7 ВОПРОС
                else if (questNum == 7)
                {
                    await SendMessage(e.Message.Chat, "Поверить хотя бы на минуту, что Вы добрая фея(прекрасный принц) ? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 8 ВОПРОС
                else if (questNum == 8)
                {
                    await SendMessage(e.Message.Chat, " Рассказать ребенку поучительный случай из детства, представляющий Вас в невыгодном свете? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 9 ВОПРОС
                else if (questNum == 9)
                {
                    await SendMessage(e.Message.Chat, "Всегда воздерживаться от употребления слов и выражений, которые могут ранить ребенка? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 10 ВОПРОС
                else if (questNum == 10)
                {
                    await SendMessage(e.Message.Chat, "Пообещать ребенку исполнить его желание за хорошее поведение? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 11 ВОПРОС
                else if (questNum == 11)
                {
                    await SendMessage(e.Message.Chat, "Выделить ребенку один день, когда он может делать, что желает, вести себя как хочет, ни во что не вмешиваться? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 12 ВОПРОС
                else if (questNum == 12)
                {
                    await SendMessage(e.Message.Chat, "Не прореагировать, если Ваш ребенок ударил, грубо толкнул или просто незаслуженно обидел другого ребенка ? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
                // 13 ВОПРОС
                else if (questNum == 13)
                {
                    await SendMessage(e.Message.Chat, "Устоять против детских просьб и слез, если уверены, что это каприз, мимолетная прихоть? ");
                    await SendMessage(e.Message.Chat, "1 - Могу и всегда так поступаю" + "\n" +
                        "2 - Могу, но не всегда так поступаю" + "\n" +
                        "3 - Не могу");
                }
            }

            switch (e.Message.Text)
            {
                case string message when message == "1":
                    scores += 3;
                    questNum++;
                    break;
                case string message when message == "2":
                    scores += 2;
                    questNum++;
                    break;
                case string message when message == "3":
                    scores += 1;
                    questNum++;
                    break;
                case string message when message == "/go":
                    questNum++;
                    break;
                default: break;
            }
            Console.WriteLine("scores: " + scores + "\n"+
                "num of question: " + questNum);
            // ИТОГ
            if (questNum > 14)
            {
                await SendMessage(e.Message.Chat, "Поздравляю! Ты прошла(шел) тест!");
                await SendMessage(e.Message.Chat, "Ты набрал(а) " + scores + " очков.\nРезультаты можно прочитать здесь: " +
                    "https://telegra.ph/Roditelskaya-odarennost-01-18");
                await SendMessage(e.Message.Chat, "Если тебе понравилось со мной общаться, поделись моей ссылкой с друзьями: t.me/iHelParentBot");
                questNum = 0;
                scores = 0;
            }
        }

        static async Task SendMessage(Chat chatId, string message)
        {
            await botClient.SendTextMessageAsync(
                  chatId: chatId,
                  text: message);
        }
    }
}
