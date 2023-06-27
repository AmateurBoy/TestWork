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
using TestWork.Models;
using TestWork.Service;

namespace TestWork
{
    public partial class Form1 : Form
    {
        //Сервисный клас для реализации логики.
        readonly StringCorrectorService stringCorrector;
        public Form1()
        {
            InitializeComponent();
            stringCorrector = new StringCorrectorService();
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
                User user = new User(NameBox.Text, LastNameBox.Text, PrefixesBox.Text);
                ResultText.Text = stringCorrector.FormattingNames(user);
            }
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
