using System;

namespace _2_4
{
    public class Employee
    {
        private string name;
        private string surname;
        private string position;
        private double experience; //years
        private const double TAX_RATE = 0.2; //20%

        public Employee(string nameInput, string surnameInput, string positionInput, double experienceInput)
        {
            name = nameInput;
            surname = surnameInput;
            position = positionInput;
            experience = experienceInput;
        }

        public double GetSalary()
        {
            int initialRate = 0;
            double experienceRate;

            switch (position)
            {
                case "директор": initialRate = 1000; break;
                case "охранник": initialRate = 400; break;
                case "уборщик": initialRate = 300; break;
                case "бухгалтер": initialRate = 600; break;
                default: break;
            }

            if(experience < 1)
            {
                experienceRate = 1;
            }
            else if(experience < 3)
            {
                experienceRate = 1.2;
            }
            else
            {
                experienceRate = 1.4;
            }

            double salary = initialRate * experienceRate * (1 - TAX_RATE);

            return salary;
        }

        public double GetTaxes()
        {
            double taxes = GetSalary() / 80 * 20;
            return taxes;
        }

        public void WriteUserInfoToConsole()
        {
            Console.WriteLine($"{name} {surname} занимает должность: {position}. Чистый оклад: {GetSalary()}. Налоговый сбор: {GetTaxes()}.");
        }
    }
}
