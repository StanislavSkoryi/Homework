using System;
using System.Linq;

namespace Igor_task2
{
    public class User
    {
        private string id;
        private string teeth;

        public User(string idInput)
        {
            if (String.IsNullOrEmpty(idInput))
            {
                throw new Exception("поле ID не может быть пустым.");
            }
                id = idInput;
        }
        public void SetTeeth(string teethInput)
        {
            string teethInputNoSpaces = teethInput.Replace(" ", "");

            if (teethInputNoSpaces.Length > 32)
            {
                throw new Exception("зубов не может быть больше 32, если вы не Леся Сацюк.");
            }
            else if (String.IsNullOrEmpty(teethInputNoSpaces))
            {
                throw new Exception("вам нужны зубы, чтобы открывать пиво.");
            }
            else if (!teethInputNoSpaces.Any(char.IsLetter))
            {
                throw new Exception("зубы должны быть буквами.");
            }
            else
            {
                teeth = teethInputNoSpaces;
            }
        }

        public string GetTeeth()
        {
            string teethUpAndLow = teeth.ToLower();
            char [] teethUpAndLowArr = teethUpAndLow.ToCharArray();

            for (int i = 0; i < teethUpAndLowArr.Length; i = i + 2)
            {
                teethUpAndLowArr[i] = char.ToUpper(teethUpAndLowArr[i]);
            }

            teethUpAndLow = new string(teethUpAndLowArr);
            return teethUpAndLow;
        }

        public void WriteUserInfoToConsole()
        {
            Console.WriteLine($"У юзера {id} вот такие зубы: {GetTeeth()}");
        }
    }


}
