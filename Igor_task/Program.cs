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
            bool nameIsNotValid = true;

            while (nameIsNotValid)
            {
                try
                {
                    Console.WriteLine("Введите имя: ");
                    User user = new User(Console.ReadLine());
                    nameIsNotValid = false;
                    user.OutputInfo();
                }
                catch (Exception a)
                {
                    Console.WriteLine($"Ошибка: {a.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}
