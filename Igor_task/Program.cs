using System;


namespace Igor_task
{
    class Program
    {
        /*
         * цель таски создать юзера правильного юзера и вывести его имя
         * если ошибка - вывести ошибку и повторить создание юзера
         */

        static void Main(string[] args)
        {
            //сюда try/catch

            Console.WriteLine("Введите имя");
            User user = new User(Console.ReadLine());

            user.OutputInfo();

            Console.ReadKey();
        }
    }
}
