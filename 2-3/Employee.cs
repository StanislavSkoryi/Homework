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
        private double salary, taxes;

        public Employee(string nameInput, string surnameInput, string positionInput, double experienceInput)
        {
            name = nameInput;
            surname = surnameInput;
            position = positionInput;
            experience = experienceInput;
        }

        public void SetSalaryAndTaxes()
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

            experienceRate = experience < 1 ? 1 : experience < 3 ? 1.2 : 1.4;

            salary = initialRate * experienceRate * (1 - TAX_RATE);

            taxes = initialRate * experienceRate * TAX_RATE;
        }

        public void WriteUserInfoToConsole()
        {
            Console.WriteLine($"{name} {surname} занимает должность: {position}. Чистый оклад: {salary}. Налоговый сбор: {taxes}.");
        }
    }
}
