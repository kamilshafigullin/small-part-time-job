using System;

namespace DemoApplication
{
    // Задание 3 «ШИФРЫ ПРОСТОЙ ЗАМЕНЫ. СИСТЕМА ШИФРОВАНИЯ ЦЕЗАРЯ»

    public static class Coding
    {

        readonly static char[] alphabet ={
                                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
                               'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};

        // str - строка для кодирования, H - шаг
        public static string Encrypt(string str, int H)
        {
            H = Math.Abs(H) % alphabet.Length;
            string result = "";
            foreach (var c in str)
            {
                // игнорируем сдвиг на символы пробела, точку и запятую
                if (c == ' ' || c == '.' || c == ',')
                {
                    result += c;
                    continue;
                }

                // находим соответствующий индекс в нашем алфавите
                int index = Array.FindIndex(alphabet, a => a == c);

                var desiredIndex = index + H;
                // проверяем, что за границы с учётом сдвига не выходит
                if (desiredIndex < alphabet.Length)
                {
                    result += alphabet[desiredIndex];
                }
                else
                {
                    result += alphabet[desiredIndex - alphabet.Length];
                }
            }

            return result.ToLower();
        }

        // str - строка для декодирования, H - шаг
        public static string Decrypt(string str, int H)
        {
            H = Math.Abs(H) % alphabet.Length;
            string result = "";
            foreach (var c in str)
            {
                // игнорируем сдвиг на символы пробела, точку и запятую
                if (c == ' ' || c == '.' || c == ',')
                {
                    result += c;
                    continue;
                }
                // находим соответствующий индекс в нашем алфавите
                int index = Array.FindIndex(alphabet, a => a == c);

                var desiredIndex = index - H;
                // проверяем, что за границы с учётом сдвига не выходит
                if (desiredIndex >= 0)
                {
                    result += alphabet[desiredIndex];
                }
                else
                {
                    result += alphabet[desiredIndex + alphabet.Length];
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сдвиг (число): ");
            int H = int.Parse(Console.ReadLine());

            Console.Write("Введите зашифрованный текст: ");
            string crypted = Console.ReadLine();

            string encrypted = Coding.Decrypt(crypted.ToLower(), H);
            Console.WriteLine("Расшифрованная строка: " + encrypted);

            Console.ReadKey();
        }
    }
}