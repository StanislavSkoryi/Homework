using System;

namespace Igor_task
{
    // лучше явно указать модификатор private
    class User
    {
        // лучше явно указать модификатор private
        string field;

        // это пока можешь удалить
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

        // Добавь конструктор с field и в конструкторе сделай проверку и засеть field

        // сразу смотри этот метод не должен быть статическим, т.к. он принадлежит только этому классу и в другом месте писать Ваше имя... не потребуется
        public static void OutputInfo(string field)
        {
            Console.WriteLine($"Ваше имя: {field}");
        }
    }

}

