using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация Мессенджера 1.
    /// </summary>
    public class Messanger1 : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр Мессенджера 1.
        /// </summary>
        /// <param name="name"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        public Messanger1(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Мессенджере 1.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // Обращение к API Мессенджера 1 для авторизации.

            Console.WriteLine($"Авторизация в Мессенджере 1 пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создать сообщение готовое для отправки в Мессенджер 1.
        /// </summary>
        /// <param name="text"> Путь к файлу картинки. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Мессенджера 1, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости, здесь можно добавить дополнительные действия.
            
            var message = new Messanger1_message(text, source, target);
            return message;
        }
    }
}
