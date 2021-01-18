using System;
using System.Linq;

namespace _2_4
{
    public class Program
    {
        public static string GetInfoFromInput(string message)
        {
            Console.WriteLine(message);
            string newElement = Console.ReadLine();
            return newElement;
        }

        public static double GetNumberFromInput(string message)
        {
            Console.WriteLine(message);
            string newElementString = Console.ReadLine();
            double newElementInt = Convert.ToDouble(newElementString);
            return newElementInt;
        }

        public static string ValidationName(string inputInfo)
        {
            if (String.IsNullOrEmpty(inputInfo))
            {
                Console.WriteLine("Поле не должно быть пустым или пробелом.");
                return null;
            }
            else if (!inputInfo.Any(char.IsLetter))
            {
                Console.WriteLine("Поле должно состоять из букв");
                return null;
            }
            else
            {
                return inputInfo;
            }
        }

        public static string ValidationPosition(string inputInfo)
        {
            if (String.IsNullOrEmpty(inputInfo))
            {
                Console.WriteLine("Поле не должно быть пустым или пробелом.");
                return null;
            }
            else if (!inputInfo.Any(char.IsLetter))
            {
                Console.WriteLine("Поле должно состоять из букв");
                return null;
            }
            else if (inputInfo == "директор" || inputInfo == "охранник" || inputInfo == "уборщик" || inputInfo == "бухгалтер")
            {
                return inputInfo;
            }
            else
            {
                Console.WriteLine("Не найдено совпадения с имеющимися должностями.");
                return null;
            }
        }

        public static double ValidationExperienceNumber(double inputNumber)
        {
            if (inputNumber == 0)
            {
                Console.WriteLine("Поле не должно быть нулем.");
                return 0;
            }
            else if (Double.IsNegativeInfinity(inputNumber))
            {
                Console.WriteLine("Поле не должно содержать отрицательных цифр.");
                return 0;
            }
            else
            {
                return inputNumber;
            }
        }

        static void Main(string[] args)
        {
            string nameInput = null, surnameInput = null, positionInput = null;
            double experienceInput = 0;

            while (nameInput == null)
            {
                nameInput = GetInfoFromInput("Введите имя:");
                nameInput = ValidationName(nameInput);
            }

            while (surnameInput == null)
            {
                surnameInput = GetInfoFromInput("Введите фамилию:");
                surnameInput = ValidationName(surnameInput);
            }

            while (positionInput == null)
            {
                positionInput = GetInfoFromInput("Введите должность:");
                positionInput = ValidationPosition(positionInput);
            }

            while (experienceInput == 0)
            {
                experienceInput = GetNumberFromInput("Введите опыт работы в годах:");
                experienceInput = ValidationExperienceNumber(experienceInput);
            }

            Employee employee = new Employee(nameInput, surnameInput, positionInput, experienceInput);

            employee.SetSalaryAndTaxes();
            employee.WriteUserInfoToConsole();

            Console.ReadKey(); //Delay
        }
    }
}
