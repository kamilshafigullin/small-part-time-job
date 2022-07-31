using System;
using System.Globalization;

namespace CinemaProjectHW1.Util
{
    public static class Utility
    {
        public static int GetIntFromConsole()
        {
            int n;
            while (true)
            {
                string line = Console.ReadLine();
                if (!int.TryParse(line, out n))
                {
                    Console.WriteLine("Неправильный формат. Введите заново.");
                    continue;
                }
                break;
            }

            return n;
        }

        public static void GetTwoIntsFromConsole(out int x, out int y)
        {
            string[] parsedStr;
            while (true)
            {
                parsedStr = Console.ReadLine().Split(' ');
                if (parsedStr.Length != 2
                || !int.TryParse(parsedStr[0], out int n1)
                || !int.TryParse(parsedStr[1], out int n2))
                    Console.WriteLine("Неправильный ввод");
                else
                    break;
            }

            x = int.Parse(parsedStr[0]);
            y = int.Parse(parsedStr[1]);
        }

        public static int GetIntFromRange(int a, int b)
        {
            int n;
            while (true)
            {
                string str = Console.ReadLine();
                if (!int.TryParse(str, out n))
                {
                    Console.WriteLine("Неправильный ввод. Введите число");
                    continue;
                }
                else if (int.Parse(str) < a || int.Parse(str) > b)
                {
                    Console.WriteLine("Указанное число не входит в диапазон. Введите заново.");
                    continue;
                }
                break;
            }

            return n;
        }

        public static DateTime GetDateTimeFromConsole()
        {
            DateTime dt;
            while (true)
            {
                string line = Console.ReadLine();
                if (!DateTime.TryParseExact(line, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {
                    Console.WriteLine("Неправильный формат. Введите заново.");
                    continue;
                }
                break;
            }

            return dt;
        }
    }
}