using System;

namespace _2_1
{
    public class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly string date = Convert.ToString(DateTime.Now);
      
        public void SetLogin(ref string loginInput)
        {
            if (!String.IsNullOrWhiteSpace(loginInput))
            {
                login = loginInput;
            }
            else
            {
                Console.WriteLine("Некорректный логин.");
                loginInput = null;
            }
        }
        public void SetName(ref string nameInput)
        {
            if (!String.IsNullOrWhiteSpace(nameInput))
            {
                name = nameInput;
            }
            else
            {
                Console.WriteLine("Некорректное имя.");
                nameInput = null;
            }
        }
        public void SetSurname(ref string surnameInput)
        {
            if (!String.IsNullOrWhiteSpace(surnameInput))
            {
                surname = surnameInput;
            }
            else
            {
                Console.WriteLine("Некорректная фамилия.");
                surnameInput = null;
            }
        }
        public void SetAge(ref int ageInput)
        {
            if (ageInput >= 1 && ageInput <= 100)
            {
                age = ageInput;
            }
            else
            {
                Console.WriteLine("Некорректный возраст");
                ageInput = 0;
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