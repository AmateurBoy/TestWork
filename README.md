# TestWork
---
Основна логіка реалізації знаходиться у сервісному класі StringCorrectorService.cs 
---
Цей проєкт було створено на основі завдання:
1) Задача. На вхід приймає ім'я і прізвище. Вони будуть написані в різному регістрі. Необхідно щоб у відповідь програма повертала ім'я і прізвище з великої літери, а решту з маленької.
2) Задача з зірочкою * Мають спрацьовувати французькі та німецькі приставки. на приклад урсула фон дер ляйн
Приклад: input: урСУла фОН ДЕр ЛяЄн => output: Урсула фон дер Ляєн
---
Для вирешення задачі було створено клас User з яким ми і будемо працювати
В ньому є 3 поля та один метод дял повернення итогової строки.
```cs
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
        //Метод для очистки від зайвих пробілів.
        public string RemoveExtraSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
```
Цю задачю я вирішив регулярними виразами та методами классу String:
Основна логіка це осі ці два методи:
1. На вхід отримуемо сущність User та передаемо його у ряд методів для редагування.
```cs
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

//Метод який першу букву піднімае у вархній регістр а інші у ніжній.
        public string GetCorrectValue(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }
```

---
2.На вхід ми повині надити слово яке требо перевірити чі є воно приставкою чі ні якщо ні то занулити значення.
```cs
//Метод для перевірки на приставку 
        public string CheckOrNullifyPrefix(string value)
        {
            //Французькі та Німецькі приставки
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
```
---
UI програми було реалізовано на WinForms:
*При введенні некоректної приставки вона буде видалена з підсумкового результату.
---
![image](https://github.com/AmateurBoy/TestWork/assets/90874301/758d0568-618b-4fe2-afe8-81a0ac019fd3)
