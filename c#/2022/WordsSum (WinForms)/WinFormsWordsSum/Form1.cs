using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsWordsSum
{
    public partial class Form1 : Form
    {
        #region Fields

        List<int> words { get; set; } = new List<int>();

        #endregion

        #region ctor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        bool IsNumber(string text)
        {
            foreach (var s in text)
            {
                if (s != '-' && s < '0' || s > '9')
                    return false;
            }

            return true;
        }

        int GetResult()
        {
            int sum = 0;
            foreach (var word in words)
            {
                var wordText = word.ToString();
                // если заканчивается на '7' - суммируем
                if (wordText[wordText.Length - 1] == '7')
                    sum += word;
            }

            return sum;
        }

        #endregion

        #region Handlers

        void ButtonAdd_Click(object sender, EventArgs e)
        {
            var wordText = WordsTextBox.Text;
            // проверка на ввод
            if (!IsNumber(wordText))
            {
                MessageBox.Show("Введено не число");
                return;
            }

            // обновляем содержимое списка на вывод
            words.Add(int.Parse(wordText));
            WordsListBox.Items.Add(wordText);
            // сразу высчитываем результат (сумму чисел, полученных из слов, заканчивающихся символом '7')
            ResultLabel.Text = GetResult().ToString();
        }

        #endregion
    }
}