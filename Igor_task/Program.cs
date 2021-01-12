using System;


namespace Igor_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            User user = new User(Console.ReadLine());

            user.OutputInfo();

            Console.ReadKey();
        }
    }
}
