using System;


namespace Igor_task
{
    class Program
    {
        static void Main(string[] args)
        {
            User name = new User();
            Console.WriteLine("Введите имя");
            name.Field = Console.ReadLine();

            if(name.Field != null) User.OutputInfo(name.Field);

            Console.ReadKey();
        }
    }
}
