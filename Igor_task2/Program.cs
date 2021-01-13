using System;

namespace Igor_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ID:");
            string idInput = Console.ReadLine();

            // а если в конструкторе ошибка?
            User user = new User(idInput);
            // по логике ты же создаешь юзера - userIsnotValid
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
