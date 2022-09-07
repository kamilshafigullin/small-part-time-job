using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StaticCalculator
{
    public partial class Form1 : Form
    {
        #region ctor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        // функция получения моды
        static double GetMode(double[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            Dictionary<double, int> dict = new Dictionary<double, int>();
            foreach (double elem in arr)
            {
                if (dict.ContainsKey(elem))
                    dict[elem]++;
                else
                    dict[elem] = 1;
            }

            int maxCount = 0;
            double mode = double.NaN;
            foreach (double elem in dict.Keys)
            {
                if (dict[elem] > maxCount)
                {
                    maxCount = dict[elem];
                    mode = elem;
                }
            }

            return mode;
        }

        // функция получения медианы
        static double GetMedin(double[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("Маccив не может быть пустым");

            if (arr.Length == 1)
                return arr[0];
            if (arr.Length % 2 == 1)
                return arr[arr.Length / 2];
            else
                return (arr[arr.Length / 2 - 1] + arr[arr.Length / 2]) / 2;
        }

        // функция получения среднего арифметического
        static double GetAvg(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum / arr.Length;
        }

        // функция получения среднего геометрического
        static double GetGeomAvg(double[] arr)
        {
            double mult = 1;
            for (int i = 0; i < arr.Length; i++)
                mult *= arr[i];

            return Math.Pow(mult, (double)1/arr.Length);
        }

        // функция получения стандартного отклонения
        static double GetStandDev(double[] arr)
        {
            double sum = 0;
            var avg = GetAvg(arr);
            for (int i = 0; i < arr.Length; i++)
                sum += (arr[i] - avg) * (arr[i] - avg);

            return Math.Sqrt(sum / arr.Length);
        }

        #endregion

        #region Handlers

        void compileButton_Click(object sender, EventArgs e)
        {
            var pathToFile = filePathTextBox.Text;
            if (!File.Exists(pathToFile))
            {
                MessageBox.Show("Неверно указан путь к файлу");
                return;
            }

            try
            {
                var x = new List<double>();
                var n = new List<double>();
                // чтение файла
                using (var reader = new StreamReader(pathToFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var xns = line.Split(' ');
                        foreach (var xn in xns)
                        {
                            var xn_array = xn.Split(';');
                            x.Add(double.Parse(xn_array[0]));
                            n.Add(double.Parse(xn_array[1]));
                        }
                    }
                }

                // вывод в график и таблицу
                chart1.Series[0].Points.Clear();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < x.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(x[i], n[i]);
                    dataGridView1.Rows.Add(x[i], n[i]);
                }

                // вычисление основных характеристик ряда
                var xArr = x.ToArray();
                var moda = GetMode(xArr); // мода
                var median = GetMedin(xArr); // медиана
                var avg = GetAvg(xArr); // ср. арифм.
                var geomAvg = GetGeomAvg(xArr); // ср. геом.
                var standDev = GetStandDev(xArr); // стандартное отклонение
                var dispersion = standDev * standDev; // дисперсия
                var sum = xArr.Sum(); // сумма
                var max = xArr.Max(); // максимум
                var min = xArr.Min(); // минимум
                var sortedList = xArr.OrderBy(xx => xx); // сортированные данные

                modaLabel.Text = moda.ToString();
                medianaLabel.Text = median.ToString();
                avgLabel.Text = avg.ToString();
                avgGeomLabel.Text = geomAvg.ToString();
                standDevLabel.Text = standDev.ToString();
                dispertionLabel.Text = dispersion.ToString();
                sumLabel.Text = sum.ToString();
                maxlabel.Text = max.ToString();
                minLabel.Text = min.ToString();
                sortedListLabel.Text = string.Join(" ", sortedList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при попытке считать файл: {ex.Message}");
            }
        }

        #endregion
    }
}