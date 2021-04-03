using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var messanger1 = new Messanger1("login", "password");
            var photo = messanger1.CreateMessage("win.jpg", "user1", "user2");
            photo.Send();

            var messanger2 = new Messanger2("login", "password");
            var text = messanger2.CreateMessage("some text", "user1", "user2");
            text.Send();

            var messanger3 = new Messanger3("login", "password");
            var text = messanger3.CreateMessage("some text", "user1", "user2");
            text.Send();

            Console.ReadLine();

            // Создаем конкретного создателя и помещаем его в обобщенного создателя.

            Creator creator = new ConcreteCreator();

            // Создаем конкретный продукт и помещаем его в обобщенный продукт.
           
            IProduct product = creator.FactoryMethod();

            // Вызываем какое-либо действие обобщенного продукта, 
            
            product.DoWork();
        }
    }
}
