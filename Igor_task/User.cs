using System;

namespace Igor_task
{
    // добавь модификатор доступа
    class User
    {
        private string field;

        public User(string fieldInput)
        {
            // try/catch лучше вынести на уровень приложения
            try
            {
                if (String.IsNullOrWhiteSpace(fieldInput))
                {
                    throw new Exception("имя не должно быть пустым или содержать пробелы.");
                }
                else if (fieldInput.Length > 20)
                {
                    throw new Exception("имя не должно содержать больше двадцати символов.");
                }
                else if (!char.IsUpper(fieldInput[0]))
                {
                    throw new Exception("имя должно начинаться с большой буквы.");
                }
                // чисто по задротски тут бы скобочки втулить если везде вверху они есть
                // если однотипно всегда лучше читается
                // else
                // {
                //     field = fieldInput;
                // }
                else
                    field = fieldInput;
            }
            catch(Exception a)
            {
                Console.WriteLine($"Ошибка: {a.Message}");
            }

        }

        public void OutputInfo()
        {
            if(field!=null) Console.WriteLine($"Ваше имя: {field}");
        }
    }

}

