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
            // этого я не написал, но добавь тут проверку на null, потому что предполагаем что id не может быть пустым 
            id = idInput;
        }

        // тут почти вопросов нет, только ж есть не только буквы и цифры ^^:) и назови SetTeeth
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

        // тут по условию нужно вернуть строку и назови GetTeeth
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

        // если по хорошему то этот метод должен явно называться WriteUserInfoToConsole 
        // или возвращать строку а уже на верхнем уровне ты это пишешь в консоль
        public void UserIdAndTeethOutputInfo()
        {
            Console.WriteLine($"У юзера {id} вот такие зубы: {teeth}");
            // этого тут быть не должно потому что допустим я пишу прогу создаю юзера и хочу отобразить инфу
            // а эта хуйня блочит выполнение
            Console.ReadKey();
        }
    }


}
