using CinemaProjectHW1.Util;
using System;
using System.Collections.Generic;

namespace CinemaProjectHW1.Models
{
    public class Film : BaseFilm
    {
        #region Properties

        public override string Name { get; set; }
        public override string AgeLimit { get; set; }
        public override int HallsCount { get; set; }
        public override List<Hall> Halls { get; set; }

        #endregion

        #region Public methods

        public override void InitHalls()
        {
            GetHallsCount();

            Halls = new List<Hall>();
            for (int i = 0; i < HallsCount; i++)
                Halls.Add(new Hall());

            Console.WriteLine($"В следующих {HallsCount} строках введите названия залов для этого фильма.");
            for (int i = 0; i < HallsCount; i++)
                Halls[i].Name = Console.ReadLine();

            for (int i = 0; i < HallsCount; i++)
                Halls[i].Init();
        }

        public void DisplayHalls()
        {
            int i = 0;
            foreach (var hall in Halls)
            {
                Console.WriteLine($"{i} - {hall.Name}");
                i++;
            }
        }

        public int GetHallByIndex()
        {
            Console.WriteLine($"Введите соответствующий порядковый номер в пределах [0;{Halls.Count - 1}]");
            int index = Utility.GetIntFromRange(0, Halls.Count - 1);

            CleanHall(index);
            return index;
        }

        public void DisplayHallSessions(int hallIndex)
        {
            int i = 0;
            foreach (var session in Halls[hallIndex].Sessions)
            {
                Console.WriteLine($"{i} - {session.DT}");
                i++;
            }
        }

        public int GetSessionByIndex(int hallIndex)
        {
            if (Halls[hallIndex].Sessions.Count == 0)
            {
                Console.WriteLine("Нет доступных сессий");
                return -1;
            }

            Console.WriteLine($"Введите соответствующий порядковый номер в пределах [0;{Halls[hallIndex].Sessions.Count - 1}]");
            int index = Utility.GetIntFromRange(0, Halls[hallIndex].Sessions.Count - 1);

            return index;
        }

        public bool TryToBookPlace(int hallIndex, int sessionIndex, int x, int y)
        {
            Console.WriteLine("Информация о брони:");

            var session = Halls[hallIndex].Sessions[sessionIndex];
            session.DisplayBookInfo();

            if (session.BookInfo[x, y] == 1)
            {
                Console.WriteLine("Данное место уже забронировано.");
                return false;
            }
            else
            {
                session.BookInfo[x, y] = 1;
                Console.WriteLine("Успешно забронировано.");
                return true;
            }
        }

        public bool TryToBuyPlace(int hallIndex, int sessionIndex, int x, int y, ref int balance, Person person)
        {
            Console.WriteLine("Информация о брони:");

            var session = Halls[hallIndex].Sessions[sessionIndex];
            session.DisplayBookInfo();

            if (session.BookInfo[x, y] == 1)
            {
                Console.WriteLine("Данное место уже забронировано.");
                return false;
            }
            else if (session.BookInfo[x, y] == 2)
            {
                Console.WriteLine("Данное место уже куплено.");
                return false;
            }
            else if (Halls[hallIndex].Prices[x, y] > balance)
            {
                Console.WriteLine("Недостаточно средств");
                return false;
            }

            balance -= Halls[hallIndex].Prices[x, y];
            person.SpentAmount += Halls[hallIndex].Prices[x, y];
            Halls[hallIndex].Sessions[sessionIndex].BookInfo[x, y] = 2;
            Console.WriteLine("Успешно куплено.");
            return true;
        }

        public int GetHallsRevenue()
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                    r += session.GetRevenue();
            }

            return r;
        }

        public int GetHallsFreePlacesCount()
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                    r += session.GetFreePlacesCount();
            }

            return r;
        }

        public int GetHallsSoldPlacesCount()
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                    r += session.GetSoldPlacesCount();
            }

            return r;
        }

        public int GetHallRevenue(Hall hall)
        {
            int r = 0;
            foreach (var session in hall.Sessions)
                r += session.GetRevenue();

            return r;
        }

        public int GetHallFreePlacesCount(Hall hall)
        {
            int r = 0;
            foreach (var session in hall.Sessions)
                r += session.GetFreePlacesCount();

            return r;
        }

        public int GetHallSoldPlacesCount(Hall hall)
        {
            int r = 0;
            foreach (var session in hall.Sessions)
                r += session.GetSoldPlacesCount();

            return r;
        }

        public int GetHallsRevenueOnPeriod(DateTime period1, DateTime period2)
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                {
                    if (session.DT > period1 && session.DT < period2)
                        r += session.GetRevenue();
                }
            }

            return r;
        }

        public int GetHallsFreePlacesCountOnPeriod(DateTime period1, DateTime period2)
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                    if (session.DT > period1 && session.DT < period2)
                        r += session.GetFreePlacesCount();
            }

            return r;
        }

        public int GetHallsSoldPlacesCountOnPeriod(DateTime period1, DateTime period2)
        {
            int r = 0;
            foreach (var hall in Halls)
            {
                foreach (var session in hall.Sessions)
                    if (session.DT > period1 && session.DT < period2)
                        r += session.GetSoldPlacesCount();
            }

            return r;
        }

        public void ChangeName()
        {
            Console.WriteLine("Введите новое название фильма:");
            string str = Console.ReadLine();
            Name = str;
            Console.WriteLine("Название успешно изменено.");
        }

        public void ChangeAgeLimit()
        {
            Console.WriteLine("Введите новое возрастное ограничение:");
            string str = Console.ReadLine();
            AgeLimit = str;
            Console.WriteLine("Возрастное ограничение успешно изменено.");
        }

        public void ChangeHallName()
        {
            DisplayHalls();
            int hallIndex = GetHallByIndex();
            var hall = Halls[hallIndex];

            Console.WriteLine($"Введите новое название для зала {hall.Name}");
            string str = Console.ReadLine();
            hall.Name = str;
            Console.WriteLine("Название успешно изменено.");
        }

        public void ChangeHallPrices()
        {
            DisplayHalls();
            int hallIndex = GetHallByIndex();
            var hall = Halls[hallIndex];

            hall.ChangePrices();
        }

        #endregion

        #region Private methods

        // метод удаления устаревших сеансов из конкретного зала
        void CleanHall(int hallIndex)
        {
            var hall = Halls[hallIndex];

            hall.Sessions.RemoveAll(session => session.DT < DateTime.Now);
        }

        void GetHallsCount()
        {
            Console.WriteLine("Введите количество залов для этого фильма:");
            HallsCount = Utility.GetIntFromConsole();
        }

        #endregion
    }
}