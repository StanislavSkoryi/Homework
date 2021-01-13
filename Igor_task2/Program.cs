using System;

namespace Igor_task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ID:");
            string idInput = Console.ReadLine();

            User user = new User(idInput);
            bool teethIsNotValid = true;

            while (teethIsNotValid)
            {
                try
                {
                    Console.WriteLine("Укажите зубы буквами:");
                    string teethInput = Console.ReadLine();
                    user.InsertTeeth(teethInput);
                    teethIsNotValid = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                }
            }

            user.TeethToUpperAndLowercase();

            user.UserIdAndTeethOutputInfo();

        }
    }
}
