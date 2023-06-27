using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestWork.Models
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string[] Prefix { get; set; }
        public User(string name, string lastName, string prefix)
        {
            Name = name.ToLower();
            LastName = lastName.ToLower();
            //Видалення зайвих пробілів та створення масиву приставок у нижньому регистрі.
            Prefix = RemoveExtraSpaces(prefix)
                .ToLower()
                .Split(' ');
        }
        public string GetFullName()
        {
            string prefix = string.Join(" ",Prefix);
            return RemoveExtraSpaces(Name +" " + prefix +" "+ LastName);
        }
        //Метод для очистки от лишних пробелов.
        public string RemoveExtraSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
}
