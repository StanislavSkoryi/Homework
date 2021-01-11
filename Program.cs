using System;

namespace _2_1
{
    // шоб уже до конца правильно этот класс нужно в отдельный файл вынести
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

        // по условию вроде дату вводить не нужно, обычно дата это дата создания обьекта по умолчанию
        public User(string date)
        {
            this.date = date;
        }
        public void OtputUserInfo()
        {
            Console.WriteLine("Данные о пользователе:");
            Console.WriteLine($"Логин: {login}, имя: {name} {surname}, возраст: {age}. Дата заполнения анкеты: {date}");
            Console.ReadKey();
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
            string message = GetInfoFromInput("Введите дату:");
            User user = new User(message);

            user.login = GetInfoFromInput("Введите логин:");
            user.name = GetInfoFromInput("Введите имя:");
            user.surname = GetInfoFromInput("Введите фамилию:");
            user.age = GetInfoFromInput("Введите свой возраст:");

            user.OtputUserInfo();
        }
    }
    */
}
