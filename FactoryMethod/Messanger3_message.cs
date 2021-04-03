using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Мессенджера 3.
    /// </summary>
    public class Messanger3_message : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Мессенджера 3.
        /// </summary>
        /// <param name="text"> Текст сообщения . </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public Messanger3_message(string text, string source, string target) : base(text, source, target)
        {
            if(text.Length <= 150)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 150);
            }
        }

        /// <summary>
        /// Отправить сообщение Мессенджера 3.
        /// </summary>
        public override void Send()
        {
            // Обращение к API Мессенджера 3 для отправки сообщения.
           
            Console.WriteLine($"Messanger3: Твит от @{Source} для @{Target}: {Text}");
        }
    }
}
