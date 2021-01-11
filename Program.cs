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
        
        static string GetInfoFromInput(string message)
        {
            Console.WriteLine(message);
            string newElement = Console.ReadLine();
            return newElement;
        }
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

        static void Main(string[] args)
        {
            string message = GetInfoFromInput("Введите дату:");
            User user = new User(message);

            user.login = GetInfoFromInput("Введите логин:");
            user.name = GetInfoFromInput("Введите имя:");
            user.surname = GetInfoFromInput("Введите фамилию:");
            user.age = GetInfoFromInput("Введите возраст:");

            user.OtputUserInfo();
        }
    }
}
