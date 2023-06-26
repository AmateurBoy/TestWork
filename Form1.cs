using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            //Перевірка на порожні поля
            if (string.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show("Имя не може бути порожнім.");
            }
            else if (string.IsNullOrEmpty(LastNameBox.Text))
            {
                MessageBox.Show("Прізвище не може бути порожнім.");
            }
            else
            {
                var result = String.Join(" ", NameBox.Text, PrefixesBox.Text, LastNameBox.Text);
                ResultText.Text = FormattingNames(result);
            }
        }

        //Метод для перевірки вводних данних та отримання результату.
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
        //Метод для перевірки на приставку 
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

        //Метод для перевірки на коректний ввід даних
        private void DelSpace(TextBox textBox)
        {
            string text = textBox.Text;
            if (text.Contains(" "))
            {
                MessageBox.Show("Виявлено пробіли! У цьому полі пробіли недоступні і видаляються.");
                text = text.Replace(" ", "");
                textBox.Text = text;
            }
        }

        //Івенти які перевіряють поля за його зміни.
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            DelSpace(NameBox);
        }  
        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            DelSpace(LastNameBox);
        }
        //Копіювання результату програми
        private void ResultText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultText.Text))
            {
                Clipboard.SetText(ResultText.Text);
                MessageBox.Show("Текст скопійовано в буфер обміну.");
            }
        }
    }
}
