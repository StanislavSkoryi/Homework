using System;

namespace _2_1
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly string date = Convert.ToString(DateTime.Now);

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        
        public static string SetLogin(string loginInput)
        {
            if (!String.IsNullOrWhiteSpace(loginInput))
            {
                return loginInput;
            }
            else
            {
                Console.WriteLine("Некорректный логин.");
                return null;
            }
        }
        public static string SetName(string nameInput)
        {
            if (!String.IsNullOrWhiteSpace(nameInput))
            {
                return nameInput;
            }
            else
            {
                Console.WriteLine("Некорректное имя.");
                return null;
            }
        }
        public static string SetSurname(string surnameInput)
        {
            if (!String.IsNullOrWhiteSpace(surnameInput) || surnameInput != "")
            {
                return surnameInput;
            }
            else
            {
                Console.WriteLine("Некорректная фамилия.");
                return null;
            }
        }
        public static int SetAge(int ageInput)
        {
            if (ageInput >= 1 && ageInput <= 100)
            {
                return ageInput;
            }
            else
            {
                Console.WriteLine("Некорректный возраст");
                return 0;
            }
        }

        public void OtputUserInfo()
        {
            Console.WriteLine("Данные о пользователе:");
            Console.WriteLine($"Логин: {login}, имя: {name} {surname}, возраст: {age}. Дата заполнения анкеты: {date}");
            Console.ReadKey();
        }
    }
}