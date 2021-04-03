using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация Мессенджера 3.
    /// </summary>
    public class Messanger3 : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр Мессенджера 3.
        /// </summary>
        /// <param name="name"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        public Messanger3(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Мессенджере 3.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // Обращение к API Мессенджера 3 для авторизации.
           
            Console.WriteLine($"Авторизация в Мессенджере 3 пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создать сообщение готовое для отправки в Мессенджер 3.
        /// </summary>
        /// <param name="text"> Текст сообщения Мессенджера 3. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Мессенджера 3, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости, здесь можно добавить дополнительные действия.
           
            var message = new Messanger3_message(text, source, target);
            return message;
        }
    }
}
