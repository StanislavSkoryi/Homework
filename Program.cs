using System;

namespace _2_1
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public string age;
        private readonly string date;

        // этот метод не должен быть в классе User, т.к ты ничего из класса не используешь
        // так же если ты изменишь Main как я написал ты его так не вызовешь как ты это делал
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


        // этот метод обычно реализуется отдельно, а не в каком-то классе
        static void Main(string[] args)
        {
            string message = GetInfoFromInput("Введите дату:");
            User user = new User(message);

            user.login = GetInfoFromInput("Введите логин:");
            user.name = GetInfoFromInput("Введите имя:");
            user.surname = GetInfoFromInput("Введите фамилию:");
            user.age = GetInfoFromInput("Введите свой возраст:");

            user.OtputUserInfo();
        }
    }

    // это плюс минус всегда должно быть так
    /*
    class Program
    {
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
    */
}

