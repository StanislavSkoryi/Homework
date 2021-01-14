using System;

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
            string loginInput = null, nameInput = null, surnameInput = null;
            int ageInput = 0;

            while (loginInput == null)
            {
                loginInput = GetInfoFromInput("Введите логин:");
                loginInput = User.SetLogin(loginInput);
            }
            while (nameInput == null)
            {
                nameInput = GetInfoFromInput("Введите имя:");
                nameInput = User.SetName(nameInput);
            }
            while (surnameInput == null)
            {
                surnameInput = GetInfoFromInput("Введите фамилию:");
                surnameInput = User.SetSurname(surnameInput);
            }
            while (ageInput == 0)
            {
                ageInput = GetNumberFromInput("Введите свой возраст:");
                ageInput = User.SetAge(ageInput);
            }

            User user = new User(loginInput, nameInput, surnameInput, ageInput);

            user.OtputUserInfo();
        }
    }
}




