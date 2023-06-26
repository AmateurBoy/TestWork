# TestWork
---
Вся логіка знаходиться у файлі Forms1.cs
---
Цей проєкт було створено на основі завдання:
1) Задача. На вхід приймає ім'я і прізвище. Вони будуть написані в різному регістрі. Необхідно щоб у відповідь програма повертала ім'я і прізвище з великої літери, а решту з маленької.
2) Задача з зірочкою * Мають спрацьовувати французькі та німецькі приставки. на приклад урсула фон дер ляйн

Приклад: input: урСУла фОН ДЕр ЛяЄн => output: Урсула фон дер Ляєн
---
Цю задачю я вирішив регулярними виразами та методами классу String:
Основна логіка це осі ці два методи:
1. На вхід отримуемо полне імя людини та передаемо його у ряд методів для редагування.
```cs
public string FormattingNames(string FullName)
        {
            //Видалення зайвих пробілів при їх наявності.
            string trimmedName = Regex.Replace(FullName, @"\s+", " ");

            //Приведення все у нижній регістр.
            string[] nameParts = trimmedName.ToLower().Split(' ');

            //Перевірка слів на приставку та реалізація логіки фільтрації слів.
            for (int i = 0; i < nameParts.Length; i++)
            {
                nameParts[i] = PrefixAnalyzer(nameParts[i]);
            }
            
            return string.Join(" ", nameParts);
        }
```

---
2.На вхід ми повині надити слово яке требо перевірити чі є воно приставкою чі ні якщо ні то виконати бізнес логіку.
```cs
 public string PrefixAnalyzer(string value)
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
                //Наводимо першу букву до верхнього регістру, інші символи до нижнього регістру
                value = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }

            return value;
        }
```
---
UI програми було реалізовано на WinForms:
---
![image](https://github.com/AmateurBoy/TestWork/assets/90874301/758d0568-618b-4fe2-afe8-81a0ac019fd3)
