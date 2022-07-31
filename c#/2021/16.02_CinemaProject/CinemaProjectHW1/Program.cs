using CinemaProjectHW1.Models;
using CinemaProjectHW1.UserType;
using CinemaProjectHW1.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProjectHW1
{

    static class Program
    {
        public static int FilmsCount => films.Count;

        public static List<Film> films;

        public static List<Person> persons = new List<Person>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите количество фильмов:");
            GetFilmsCount();

            Console.WriteLine($"В следующих {FilmsCount} строках введите названия этих фильмов:");
            GetFilmsName();

            Console.WriteLine($"В следующих {FilmsCount} строках введите возрастные рейтинги для этих фильмов:");
            GetFilmsAgeLimit();

            GetFilmsHall();

            Console.WriteLine("Данные успешно сохранены");

            while (true)
            {
                Console.WriteLine("Если вы хотите продолжить как администратор - введите 1, как клиент - любую другую клавишу");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Admin.StartAdminInterfaice();
                }
                else
                {
                    Console.WriteLine();
                    Client.StartClientInterfaice();
                }
            }
        }

        static void GetFilmsCount()
        {
            int filmsCount;
            while (true)
            {
                var line = Console.ReadLine();
                if (!int.TryParse(line, out filmsCount))
                {
                    Console.WriteLine("Указан не целочисленный тип. Введите заново.");
                    continue;
                }
                break;
            }

            InitFilms(filmsCount);
        }

        static void InitFilms(int filmsCount)
        {
            films = new List<Film>();
            for (int i = 0; i < filmsCount; i++)
                films.Add(new Film());
        }

        static void GetFilmsName()
        {
            for (int i = 0; i < FilmsCount; i++)
                films[i].Name = Console.ReadLine();
        }

        static void GetFilmsAgeLimit()
        {
            for (int i = 0; i < FilmsCount; i++)
                films[i].AgeLimit = Console.ReadLine();
        }

        static void GetFilmsHall()
        {
            for (int i = 0; i < FilmsCount; i++)
            {
                Console.WriteLine($"Теперь укажем информацию о залах фильма {films[i].Name}");
                films[i].InitHalls();
            }
        }

        public static void DisplayFilms()
        {
            int i = 0;
            foreach (var film in films)
            {
                Console.WriteLine($"{i} - {film.Name}");
                i++;
            }
        }

        public static int GetFilmByIndex()
        {
            Console.WriteLine($"Введите соответствующий порядковый номер в пределах [0;{FilmsCount - 1}]");
            int index = Utility.GetIntFromRange(0, FilmsCount - 1);
            return index;
        }

        public static void GetIndexes(out int filmIndex, out int hallIndex, out int sessionIndex)
        {
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            filmIndex = GetFilmByIndex();

            Console.WriteLine($"Доступные залы фильма {films[filmIndex].Name}");
            films[filmIndex].DisplayHalls();
            hallIndex = films[filmIndex].GetHallByIndex();

            Console.WriteLine($"Доступные сеансы зала {films[filmIndex].Halls[hallIndex].Name}");
            films[filmIndex].DisplayHallSessions(hallIndex);
            sessionIndex = films[filmIndex].GetSessionByIndex(hallIndex);
        }
    }
}