using System;

namespace _2_1
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;

        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        private readonly string date = Convert.ToString(DateTime.Now);

        public static void Validate(string login, string name, string surname, int age)
        {
            User field = new User();
            bool allInfoIsValid = false, loginIsValid = false, nameIsValid = false, surnameIsValid = false, ageIsValid = false;

            if (!String.IsNullOrWhiteSpace(login))
            {
                
                field.login = login;
                loginIsValid = true;
            }
            else
                Console.WriteLine("Некорректный логин.");

            if (!String.IsNullOrWhiteSpace(name))
            { 
                field.name = name;
                nameIsValid = true;
            }
            else
                Console.WriteLine("Некорректное имя.");

            if (!String.IsNullOrWhiteSpace(surname))
            {
                field.surname = surname;
                surnameIsValid = true;
            }
            else
                Console.WriteLine("Некорректная фамилия");

            if (age >= 1 && age <= 100)
            {
                field.age = age;
                ageIsValid = true;
            }
            else
                Console.WriteLine("Некорректный возраст");

            allInfoIsValid = loginIsValid && nameIsValid && surnameIsValid & ageIsValid;
        }
        public void OtputUserInfo()
        {
            Console.WriteLine("Данные о пользователе:");
            Console.WriteLine($"Логин: {_login}, имя: {_name} {_surname}, возраст: {_age}. Дата заполнения анкеты: {date}");
            Console.ReadKey();
        }

    }
}