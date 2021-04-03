using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализация Мессенджера 2.
    /// </summary>
    public class Messanger2 : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр Мессенджера 2.
        /// </summary>
        /// <param name="name"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        public Messanger2(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Мессенджере 2.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // Обращение к API Мессенджера 2 для авторизации.
            
            Console.WriteLine($"Авторизация в Мессенджере 2 пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создать сообщение готовое для отправки в Мессенджер 2.
        /// </summary>
        /// <param name="text"> Текст сообщения Мессенджера 2. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Мессенджера 2, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости, здесь можно добавить дополнительные действия.
           
            var message = new Messanger2_message(text, source, target);
            return message;
        }
    }
}
