using System;

namespace DemoApplication
{
    // Задание 1 «ОДИНОЧНАЯ ПЕРЕСТАНОВКА»

    public static class Coding
    {
        // str - строка для шифрования, key - ключ (размер таблицы)
        public static string Encrypt(string str, int key)
        {
            // Убираем пробелы с исходной строки
            str = str.Replace(" ", string.Empty);
            // Высчитываем кол-во колонок таблицы
            int cols = (int)Math.Ceiling((double)str.Length / key);

            char[,] table = new char[key, cols];

            int i = 0;
            int j = 0;
            foreach (var c in str)
            {
                table[i++, j] = c;

                // Переход на следующую колонку
                if (i == key)
                {
                    i = 0;
                    j++;
                }
            }

            // Результирующая строка
            string result = string.Empty;
            for (int i1 = 0; i1 < key; i1++)
            {
                for (int j1 = 0; j1 < cols; j1++)
                {
                    result += table[i1, j1];
                    if (result.Replace(" ", string.Empty).Length % 4 == 0)
                        result += " ";
                }
            }

            return result;
        }

        // // str - строка для дешифрования, key - ключ (размер таблицы)
        public static string Decrypt(string str, int key)
        {
            // Убираем пробелы с исходной строки
            str = str.Replace(" ", string.Empty);
            // Высчитываем кол-во колонок таблицы
            int cols = (int)Math.Ceiling((double)str.Length / key);

            char[,] table = new char[key, cols];

            int i = 0;
            int j = 0;
            foreach (var c in str)
            {
                table[i, j++] = c;

                // Переход на следующую строку
                if (j == cols)
                {
                    j = 0;
                    i++;
                }
            }

            // Результирующая строка
            string result = string.Empty;
            for (int j1 = 0; j1 < cols; j1++)
            {
                for (int i1 = 0; i1 < key; i1++)
                    result += table[i1, j1];
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ (число): ");
            int key = int.Parse(Console.ReadLine());

            Console.Write("Введите зашифрованный текст: ");
            string crypted = Console.ReadLine();

            string encrypted = Coding.Decrypt(crypted.ToLower(), key);
            Console.WriteLine("Расшифрованная строка: " + encrypted);

            Console.ReadKey();
        }
    }
}