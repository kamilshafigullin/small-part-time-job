using CinemaProjectHW1.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectHW1.Models
{
    public class Hall
    {
        public int N;
        public int M;

        public string Name { get; set; }

        public int[,] BookInfo { get; set; }

        public int[,] Prices { get; set; }

        public List<Session> Sessions { get; set; } = new List<Session>();

        public Hall()
        {
        }

        #region Public methods

        public void Init()
        {
            SetLength();
            SetPrices();
            SetSessions();
        }

        public void ChangePrices()
        {
            SetPrices();
        }

        #endregion

        #region Private methods

        void SetLength()
        {
            while (true)
            {
                Console.WriteLine($"Введите через пробел размер зала {Name}");
                var size = Console.ReadLine().Split(' ');
                if (size.Length != 2
                || !int.TryParse(size[0], out N)
                || !int.TryParse(size[1], out M))
                {
                    Console.WriteLine("Указан неверный формат");
                    continue;
                }

                break;
            }
        }

        void SetPrices()
        {
            Prices = new int[N, M];
            Console.WriteLine($"В следующих {N} строках введите через пробел дефолтные стоимости мест по рядам для данного зала:");
            int n = 0;
            int m = 0;
            while (n != N)
            {
                Console.WriteLine($"Введите для ряда №{n}:");
                var line = Console.ReadLine().Split(' ');
                if (line.Length != M)
                {
                    Console.WriteLine("Указано неверное количество цен");
                    continue;
                }
                m = 0;
                foreach (var price in line)
                {
                    if (!int.TryParse(price, out Prices[n, m++]))
                    {
                        Console.WriteLine("Замечены нечисловые символы. Введите заново.");
                        continue;
                    }
                }

                n++;
            }
        }

        void SetSessions()
        {
            Console.WriteLine("Введите количество временных сеансов/слотов для этого зала:");
            int n = Utility.GetIntFromConsole();

            Console.WriteLine($"В следующих {n} строках введите дату и время сеансов в формате дд.ММ.гггг чч:мм");
            for (int i = 0; i < n; i++)
            {
                var session = new Session(N, M);
                session.Prices = Prices;
                session.DT = Utility.GetDateTimeFromConsole();
                Sessions.Add(session);
            }
        }

        #endregion
    }
}