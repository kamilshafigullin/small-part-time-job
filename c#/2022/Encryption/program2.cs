using System;

namespace DemoApplication
{
    // Задание 2 «ОДИНОЧНАЯ ПЕРЕСТАНОВКА ПО КЛЮЧУ»

    public static class Coding
    {
        // str - строка для шифрования, key - ключ
        public static string Encrypt(string str, string key)
        {
            str = str.Replace(" ", string.Empty);

            int rows = (int)Math.Ceiling((double)str.Length / key.Length);
            char[,] table = new char[rows, key.Length];

            int strIndex = 0;
            for (int j = 0; j < key.Length; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    table[i, j] = str[strIndex++];
                }
            }

            var keyArray = key.ToCharArray();
            Array.Sort(keyArray);

            // Формируем новую таблицу с учётом перестановки
            char[,] sortedTable = new char[rows, key.Length];
            for (int j = 0; j < keyArray.Length; j++)
            {
                var keyIndex = key.IndexOf(keyArray[j]);
                for (int i = 0; i < rows; i++)
                {
                    sortedTable[i, j] = table[i, keyIndex];
                }
            }

            string result = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    result += sortedTable[i, j];
                }
            }

            return result;
        }

        // str - строка для дешифрования, key - ключ
        public static string Decrypt(string str, string key)
        {
            str = str.Replace(" ", string.Empty);

            int rows = (int)Math.Ceiling((double)str.Length / key.Length);
            char[,] table = new char[rows, key.Length];

            int strIndex = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    table[i, j] = str[strIndex++];
                }
            }

            var keyArray = key.ToCharArray();
            Array.Sort(keyArray);

            // Формируем новую таблицу с учётом перестановки
            char[,] sortedTable = new char[rows, key.Length];
            for (int j = 0; j < keyArray.Length; j++)
            {
                var keyIndex = new string(keyArray).IndexOf(key[j]);
                for (int i = 0; i < rows; i++)
                {
                    sortedTable[i, j] = table[i, keyIndex];
                }
            }

            string result = string.Empty;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    result += sortedTable[j, i];
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ: ");
            string key = Console.ReadLine();

            Console.Write("Введите зашифрованный текст: ");
            string crypted = Console.ReadLine();

            string encrypted = Coding.Decrypt(crypted.ToLower(), key);
            Console.WriteLine("Расшифрованная строка: " + encrypted);

            Console.ReadKey();
        }
    }
}