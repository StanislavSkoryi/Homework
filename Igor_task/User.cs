using System;

namespace Igor_task
{
    class User
    {
        string field;
        public string Field
        {
            get
            {
                return field;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Имя не должно быть пустым или содержать пробелы.");
                }
                else if (value.Length > 20)
                {
                    Console.WriteLine("Имя не должно содержать больше двадцати символов.");
                }
                else if (!char.IsUpper(value[0]))
                {
                    Console.WriteLine("Имя должно начинаться с большой буквы.");
                }
                else
                    field = value;
            }
        }
        public static void OutputInfo(string field)
        {
            Console.WriteLine($"Ваше имя: {field}");
        }
    }

}

