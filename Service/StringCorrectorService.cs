using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWork.Models;

namespace TestWork.Service
{
    public class StringCorrectorService
    {
        //Метод для перевірки вводних данних та отримання результату.
        public string FormattingNames(User user)
        {
            //Коректування імені та прізвища
            user.Name = GetCorrectValue(user.Name);
            user.LastName = GetCorrectValue(user.LastName);

            //Перевірка приставок.
            for (int i = 0; i < user.Prefix.Length; i++)
            {
                user.Prefix[i] = CheckOrNullifyPrefix(user.Prefix[i]);
            }
            return user.GetFullName();
        }
        //Метод для який першу букву піднімае у вархній регістр а інші у ніжній.
        public string GetCorrectValue(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }

        //Метод для перевірки на приставку 
        public string CheckOrNullifyPrefix(string value)
        {
            //Французькі приставки та Німецькі приставки
            string frenchPrefixPattern = @"\b(de|du|des|d'|де|дю|дес|д')\b";
            string germanPrefixPattern = @"\b(von|van|der|zu|zum|zur|фон|ван|дер|цу|цум|цур)\b";

            //Перевіряємо наявність французької чи німецької приставки
            bool isFrenchPrefix = Regex.IsMatch(value, frenchPrefixPattern, RegexOptions.IgnoreCase);
            bool isGermanPrefix = Regex.IsMatch(value, germanPrefixPattern, RegexOptions.IgnoreCase);

            //Якщо є приставка, наводимо все слово до нижнього регістру
            if (isFrenchPrefix || isGermanPrefix)
            {
                value = value.ToLower();
            }
            else
            {
                //занулення не коректної приставки
                return null;
            }

            return value;
        }
        
    }
}
