using System;

namespace DemoApplication
{
    // Задание 4 «ШИФР СЛОЖНОЙ ЗАМЕНЫ.ШИФР ГРОНСФЕЛЬДА»

    public static class Coding
    {

        readonly static char[] alphabet = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О',
                                'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',
                                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                               'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};

        // str - строка для кодирования, key - ключ
        public static string Encrypt(string str, int key)
        {
            int len = str.Length;

            int[] keyArray = new int[len];
            int keyIndex = 0;

            // Переводим ключ в строку, чтобы можно было обращаться по индексу
            var keyStr = key.ToString();
            // Циклически формируем ключевой массив
            for (int i = 0; i < len; i++)
            {
                // -1 будет являться признаком того, что это символ "пробел"
                if (str[i] == ' ')
                {
                    keyArray[i] = -1;
                    continue;
                }

                keyArray[i] = int.Parse(keyStr[keyIndex++ % keyStr.Length].ToString());
            }

            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                if (keyArray[i] != -1)
                {
                    var alphabetIndex = Array.FindIndex(alphabet, a => a == str[i]);
                    result += alphabet[(alphabetIndex + keyArray[i]) % alphabet.Length];
                }
                else
                {
                    result += " ";
                }
            }

            return result;
        }

        // str - строка для декодирования, key - ключ
        public static string Decrypt(string str, int key)
        {
            int len = str.Length;

            int[] keyArray = new int[len];
            int keyIndex = 0;

            var keyStr = key.ToString();
            // Циклически формируем ключевой массив
            for (int i = 0; i < len; i++)
            {
                if (str[i] != ' ')
                    keyArray[i] = int.Parse(keyStr[keyIndex++ % keyStr.Length].ToString());
                else
                    keyArray[i] = -1;
            }

            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                if (keyArray[i] == -1)
                {
                    result += " ";
                    continue;
                }

                var alphabetIndex = Array.FindIndex(alphabet, a => a == str[i]);
                // Условия для корректного циклического сдвига влево
                if (alphabetIndex - keyArray[i] >= 0)
                    result += alphabet[alphabetIndex - keyArray[i]];
                else
                    result += alphabet[alphabet.Length - (alphabetIndex - keyArray[i])];
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