using System;
using System.IO;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация сообщения Мессенджера 1.
    /// Принимает сообщение в виде картинки.
    /// </summary>
    public class Messanger1_message : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Мессенджера 1.
        /// </summary>
        /// <param name="text"> Путь к файлу изображения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public Messanger1_message(string text, string source, string target) : base(text, source, target)
        {
            if(File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }

        /// <summary>
        /// Отправить сообщение Мессенджера 1.
        /// </summary>
        public override void Send()
        {
            // Обращение к API Мессенджера 1 для отправки сообщения.

            Console.WriteLine($"Messanger1: Фото от @{Source} для @{Target}: {Text}");
        }
    }
}
