using System;

namespace _2_1
{
    public class Program
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

            string loginInput = null, nameInput = null, surnameInput = null;
            int ageInput = 0;

            while (loginInput == null)
            {
                loginInput = GetInfoFromInput("Введите логин:");
                user.SetLogin(ref loginInput);
            }
            while (nameInput == null)
            {
                nameInput = GetInfoFromInput("Введите имя:");
                user.SetName(ref nameInput);
            }
            while (surnameInput == null)
            {
                surnameInput = GetInfoFromInput("Введите фамилию:");
                user.SetSurname(ref surnameInput);
            }
            while (ageInput == 0)
            {
                ageInput = GetNumberFromInput("Введите свой возраст:");
                user.SetAge(ref ageInput);
            }

            user.OtputUserInfo();
        }
    }
}




