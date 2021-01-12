using System;
using System.IO;

namespace _2_1
{
    class Program 
    {
        static string GetInfoFromInput(string message)
        {
            Console.WriteLine(message);
            string newElement = Console.ReadLine();
            return newElement;
        }
        static int GetNumberFromInput(string message)
        {
            Console.WriteLine(message);
            string newElementString = Console.ReadLine();
            int newElementInt = Convert.ToInt32(newElementString);
            return newElementInt;
        }

        static void Main(string[] args)
        {
            User user = new User();

            string login = GetInfoFromInput("Введите логин:");
            string name = GetInfoFromInput("Введите имя:");
            string surname = GetInfoFromInput("Введите фамилию:");
            int age = GetNumberFromInput("Введите свой возраст:");

            User.Validate(login, name, surname, age);

            //user.login = GetInfoFromInput("Введите логин:");
            //user.name = GetInfoFromInput("Введите имя:");
            //user.surname = GetInfoFromInput("Введите фамилию:");
            //user.age = GetInfoFromInput("Введите свой возраст:");

            user.OtputUserInfo();
        }
    }
}

