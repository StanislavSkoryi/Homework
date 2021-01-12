using System;

namespace _2_1
{
    class User
    {
        string loginField;
        string nameField;
        string surnameField;
        int ageField;

        public string Login
        {
            get
            {
                return loginField;
            }
            set
            {
                loginField = value;
            }
        }
        public string Name { get; set ; }
        public string Surname { get; set; }
        public int Age { get; set; }


        private readonly string date = Convert.ToString(DateTime.Now);

        public static void Validate(string loginInput, string name, string surname, int age)
        {
            User field = new User();
            bool allInfoIsValid = false, loginIsValid = false, nameIsValid = false, surnameIsValid = false, ageIsValid = false;

            if (!String.IsNullOrWhiteSpace(loginInput))
            {
                
                field.Login = loginInput;
                loginIsValid = true;
            }
            else
                Console.WriteLine("Некорректный логин.");

            if (!String.IsNullOrWhiteSpace(name))
            { 
                field.Name = name;
                nameIsValid = true;
            }
            else
                Console.WriteLine("Некорректное имя.");

            if (!String.IsNullOrWhiteSpace(surname))
            {
                field.Surname = surname;
                surnameIsValid = true;
            }
            else
                Console.WriteLine("Некорректная фамилия");

            if (age >= 1 && age <= 100)
            {
                field.Age = age;
                ageIsValid = true;
            }
            else
                Console.WriteLine("Некорректный возраст");

            allInfoIsValid = loginIsValid && nameIsValid && surnameIsValid & ageIsValid;
        }
        public void OtputUserInfo()
        {
            Console.WriteLine("Данные о пользователе:");
            Console.WriteLine($"Логин: {loginField}, имя: {nameField} {surnameField}, возраст: {ageField}. Дата заполнения анкеты: {date}");
            Console.ReadKey();
        }

    }
}