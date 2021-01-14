using System;

namespace Igor_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputIsNotValid = true;

            while (inputIsNotValid)
            {
                try
                {
                    Console.WriteLine("Введите ID:");
                    string idInput = Console.ReadLine();
                    User user = new User(idInput);

                    Console.WriteLine("Укажите зубы буквами:");
                    string teethInput = Console.ReadLine();
                    user.SetTeeth(teethInput);

                    inputIsNotValid = false;

                    user.GetTeeth();

                    user.WriteUserInfoToConsole();

                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                }
            }
        }
    }
}
