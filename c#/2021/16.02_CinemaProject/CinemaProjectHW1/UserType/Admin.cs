using CinemaProjectHW1.Models;
using CinemaProjectHW1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using static CinemaProjectHW1.Program;

namespace CinemaProjectHW1.UserType
{
    public static class Admin
    {
        static string adminPass = "123";

        public static void StartAdminInterfaice()
        {
            Console.WriteLine("Введите пароль:");
            if (!string.Equals(adminPass, Console.ReadLine()))
            {
                Console.WriteLine("Неверный пароль");
                return;
            }

            while (true)
            {
                Console.WriteLine("Введите 1, чтобы изменить данные о кинотеатре");
                Console.WriteLine("Введите 2, чтобы вывести аналитику по продажам");
                Console.WriteLine("Введите 3, чтобы произвести клиентскую аналитику");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        ChangeCinemaInfo();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        AnalyseCinema();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        AnalyseClients();
                        break;
                    default:
                        return;
                }
            }
        }

        static void AnalyseClients()
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("Пока клиентов нет.");
                return;
            }

            var sortedPersons = persons.OrderByDescending(s => s.SpentAmount);

            Console.WriteLine("<ФИО> <Количество потраченных денег>");
            foreach (var person in sortedPersons)
                Console.WriteLine($"<{person.FIO}> <{person.SpentAmount}>");
        }

        #region Change Cinema Info

        static void ChangeCinemaInfo()
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - добавить фильм");
            Console.WriteLine("2 - удалить фильм");
            Console.WriteLine("3 - изменить данные о фильме");
            Console.WriteLine("любая другая клавиша - выйти");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    AddFilm();
                    return;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    RemoveFilm();
                    return;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    EditFilm();
                    return;
                default:
                    return;
            }
        }

        static void AddFilm()
        {
            var film = new Film();

            Console.WriteLine("Введите название фильма:");
            film.Name = Console.ReadLine();
            Console.WriteLine("Введите возрастное ограничение фильма:");
            film.AgeLimit = Console.ReadLine();
            film.InitHalls();

            films.Add(film);
            Console.WriteLine("Фильм успешно добавлен.");
        }

        static void RemoveFilm()
        {
            int filmIndex;
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            filmIndex = GetFilmByIndex();

            films.RemoveAt(filmIndex);
            Console.WriteLine("Фильм успешно удалён.");
        }

        static void EditFilm()
        {
            int filmIndex;
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            filmIndex = GetFilmByIndex();
            var film = films[filmIndex];

            Console.WriteLine("Изменить имя фильма?\n1 - да, любая другая клавиша - нет");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                film.ChangeName();
            }

            Console.WriteLine("Изменить возрастное ограничение на фильм?\n1 - да, любая другая клавиша - нет");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                film.ChangeAgeLimit();
            }

            Console.WriteLine("Изменить названия залов?\n1 - да, любая другая клавиша - нет");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                film.ChangeHallName();
            }

            Console.WriteLine("Изменить цены на билеты конкретного зала и фильма?\n1 - да, любая другая клавиша - нет");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine();
                film.ChangeHallPrices();
            }
        }

        #endregion

        #region Cinema Analyse

        static void AnalyseCinema()
        {
            while (true)
            {
                Console.WriteLine("Выберите фильтр");
                Console.WriteLine("1 - на один конкретный фильм");
                Console.WriteLine("2 - в одном конкретном зале");
                Console.WriteLine("3 - на одном конкретном сеансе");
                Console.WriteLine("4 - по указанному периоду по всем фильмам");
                Console.WriteLine("5 - за весь период по всем фильмам");
                Console.WriteLine("6 - по возрастному рейтингу");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        AnalyseConcreteFilm();
                        return;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        AnalyseConcreteHall();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        AnalyseConcreteSession();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        AnalyseOnPeriod();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine();
                        AnalyseOnAllFilms();
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine();
                        AnalyseOnAgeLimit();
                        break;
                    default:
                        Console.WriteLine();
                        return;
                }
            }
        }

        static void AnalyseConcreteFilm()
        {
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            int filmIndex = GetFilmByIndex();
            var film = films[filmIndex];

            Console.WriteLine($"Количество проданных мест: {film.GetHallsSoldPlacesCount()}");
            Console.WriteLine($"Количество свободных мест: {film.GetHallsFreePlacesCount()}");
            Console.WriteLine($"Общая выручка: {film.GetHallsRevenue()}");
        }

        static void AnalyseConcreteHall()
        {
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            int filmIndex = GetFilmByIndex();
            var film = films[filmIndex];

            film.DisplayHalls();
            int hallIndex = film.GetHallByIndex();
            var hall = film.Halls[hallIndex];

            Console.WriteLine($"Количество проданных мест: {film.GetHallSoldPlacesCount(hall)}");
            Console.WriteLine($"Количество свободных мест: {film.GetHallFreePlacesCount(hall)}");
            Console.WriteLine($"Общая выручка: {film.GetHallRevenue(hall)}");
        }

        static void AnalyseConcreteSession()
        {
            Console.WriteLine("Доступные фильмы:");
            DisplayFilms();
            int filmIndex = GetFilmByIndex();
            var film = films[filmIndex];

            film.DisplayHalls();
            int hallIndex = film.GetHallByIndex();
            var hall = film.Halls[hallIndex];

            film.DisplayHallSessions(hallIndex);
            int sessionIndex = film.GetSessionByIndex(hallIndex);
            var session = hall.Sessions[sessionIndex];

            Console.WriteLine($"Количество проданных мест: {session.GetSoldPlacesCount()}");
            Console.WriteLine($"Количество свободных мест: {session.GetFreePlacesCount()}");
            Console.WriteLine($"Общая выручка: {session.GetRevenue()}");
        }

        static void AnalyseOnPeriod()
        {
            Console.WriteLine("Введите стартовый период:");
            var period1 = Utility.GetDateTimeFromConsole();
            Console.WriteLine("Введите конечный период:");
            var period2 = Utility.GetDateTimeFromConsole();

            int soldPlacesCount = 0;
            int freePlacesCount = 0;
            int revenue = 0;

            films.ForEach(film => soldPlacesCount += film.GetHallsSoldPlacesCountOnPeriod(period1, period2));
            films.ForEach(film => freePlacesCount += film.GetHallsFreePlacesCountOnPeriod(period1, period2));
            films.ForEach(film => revenue += film.GetHallsRevenueOnPeriod(period1, period2));

            Console.WriteLine($"Количество проданных мест: {soldPlacesCount}");
            Console.WriteLine($"Количество свободных мест: {freePlacesCount}");
            Console.WriteLine($"Общая выручка: {revenue}");
        }

        static void AnalyseOnAllFilms()
        {
            int soldPlacesCount = 0;
            int freePlacesCount = 0;
            int revenue = 0;

            films.ForEach(film => soldPlacesCount += film.GetHallsSoldPlacesCount());
            films.ForEach(film => freePlacesCount += film.GetHallsFreePlacesCount());
            films.ForEach(film => revenue += film.GetHallsRevenue());

            Console.WriteLine($"Количество проданных мест: {soldPlacesCount}");
            Console.WriteLine($"Количество свободных мест: {freePlacesCount}");
            Console.WriteLine($"Общая выручка: {revenue}");
        }

        static void AnalyseOnAgeLimit()
        {
            Console.WriteLine("Введите возрастное ограничение:");
            string ageLimit = Console.ReadLine();

            var filmsOnAgeLimit = films.Where(film => string.Equals(film.AgeLimit, ageLimit));

            if (filmsOnAgeLimit.Count() == 0)
            {
                Console.WriteLine("Фильмов с таким возрастным ограничением не найдено");
                return;
            }

            int soldPlacesCount = 0;
            int freePlacesCount = 0;
            int revenue = 0;

            filmsOnAgeLimit.ToList().ForEach(film => soldPlacesCount += film.GetHallsSoldPlacesCount());
            filmsOnAgeLimit.ToList().ForEach(film => freePlacesCount += film.GetHallsFreePlacesCount());
            filmsOnAgeLimit.ToList().ForEach(film => revenue += film.GetHallsRevenue());

            Console.WriteLine($"Количество проданных мест: {soldPlacesCount}");
            Console.WriteLine($"Количество свободных мест: {freePlacesCount}");
            Console.WriteLine($"Общая выручка: {revenue}");
        }

        #endregion
    }
}