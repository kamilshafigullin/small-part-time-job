using System;

namespace DemoApplication
{
    // Задание 5 «ШИФР МНОГОАЛФАВИТНОЙ ЗАМЕНЫ»

    public static class Coding
    {
        readonly static char[] alphabet = {
                                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                               'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', '_' };

        // str - строка для дешифрования, key - ключ
        public static string Decrypt(string str, string key)
        {
            GetValidKey(ref key, str.Length);

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                var keyIndex = Array.FindIndex(alphabet, a => a == key[i]);
                var charIndex = Array.FindIndex(alphabet, a => a == str[i]);

                result += alphabet[(charIndex + keyIndex) % alphabet.Length];
            }

            return result;
        }

        // функция привидения ключа к валидному состоянию
        // key - ключ, strLen - длина зашифрованной строки
        static void GetValidKey(ref string key, int strLen)
        {
            // циклически повторяем ключ, если его длина оказалась меньше длины зашифрованной строки
            while (key.Length < strLen)
                key += key;
            // приводим длину ключа к длине зашифрованной строки
            key.Remove(0, strLen);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ: ");
            string key = Console.ReadLine();

            if (string.IsNullOrEmpty(key))
            {
                Console.WriteLine("Ключ не может быть пустым");
                return;
            }

            Console.Write("Введите зашифрованный текст: ");
            string crypted = Console.ReadLine().Replace(" ", string.Empty);

            string encrypted = Coding.Decrypt(crypted.ToLower(), key.ToLower());
            Console.WriteLine("Расшифрованная строка: " + encrypted);

            Console.ReadKey();
        }
    }
}