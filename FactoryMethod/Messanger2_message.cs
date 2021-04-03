using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Мессенджера 2.
    /// </summary>
    public class Messanger2_message : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Мессенджера 2.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public Messanger2_message(string text, string source, string target) : base(text, source, target) { }

        /// <summary>
        /// Отправить сообщение Мессенджера 2.
        /// </summary>
        public override void Send()
        {
            // Обращение к API Мессенджера 2 для отправки сообщения.
            
            Console.WriteLine($"Messanger2: Текст от @{Source} для @{Target}: {Text}");
        }
    }
}
