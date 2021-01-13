using System;
using System.Linq;

namespace Igor_task2
{
    class User
    {
        private string id;
        private string teeth;

        public User(string idInput)
        {
            id = idInput;
        }
        public void InsertTeeth(string teethInput)
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
            else if (teethInputNoSpaces.Any(char.IsDigit))
            {
                throw new Exception("зубы не должны содержать цифры.");
            }
            else
            {
                teeth = teethInputNoSpaces;
            }
        }

        public void TeethToUpperAndLowercase()
        {
            teeth = teeth.ToLower();
            char [] teethToUpperAndLowercase = teeth.ToCharArray();

            for (int i = 0; i < teethToUpperAndLowercase.Length; i = i + 2)
            {
                teethToUpperAndLowercase[i] = char.ToUpper(teethToUpperAndLowercase[i]);
            }

            teeth = new string(teethToUpperAndLowercase);
        }

        public void UserIdAndTeethOutputInfo()
        {
            Console.WriteLine($"У юзера {id} вот такие зубы: {teeth}");
            Console.ReadKey();
        }
    }


}
