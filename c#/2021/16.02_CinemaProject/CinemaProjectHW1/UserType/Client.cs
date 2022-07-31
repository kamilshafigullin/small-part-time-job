using CinemaProjectHW1.Models;
using CinemaProjectHW1.Util;
using System;
using System.Collections.Generic;
using static CinemaProjectHW1.Program;

namespace CinemaProjectHW1.UserType
{
    public static class Client
    {
        static Person person;
        static int balance;

        static List<Ticket> purchasedTickets { get; set; }

        public static void StartClientInterfaice()
        {
            purchasedTickets = new List<Ticket>();

            Console.WriteLine("Вы успешно вошли как клиент.");

            Console.WriteLine("Введите ФИО");
            person = new Person()
            {
                FIO = Console.ReadLine()
            };

            Console.WriteLine("Введите начальное значение своего баланса:");
            balance = Utility.GetIntFromConsole();

            while (true)
            {
                Console.WriteLine("Введите 1, чтобы узнать свой баланс");
                Console.WriteLine("Введите 2, чтобы пополнить свой баланс");
                Console.WriteLine("Введите 3, чтобы забронировать билет");
                Console.WriteLine("Введите 4, чтобы купить билет");
                Console.WriteLine("Введите 5, чтобы просмотреть список купленных билетов");
                Console.WriteLine("Введите 6, чтобы узнать информацию о брони");
                Console.WriteLine("Любая другая клавиша - выйти");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        DisplayBalance();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        EditBalance();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        BookPlace();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        BuyTicket();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine();
                        DisplayPurchasedTickets();
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine();
                        DisplayBookInfo();
                        break;
                    default:
                        Console.WriteLine();
                        persons.Add(new Person { FIO = person.FIO, SpentAmount = person.SpentAmount });
                        return;
                }
            }
        }

        static void DisplayBalance()
        {
            Console.WriteLine($"Ваш баланс: {balance}");
        }

        static void EditBalance()
        {
            Console.WriteLine("Введите сумму, на которое вы желаете увеличить свой баланс:");
            balance += Utility.GetIntFromConsole();
            Console.WriteLine("Ваш баланс успешно пополнен.");
        }

        static void BookPlace()
        {
            int filmIndex, hallIndex, sessionIndex;
            GetIndexes(out filmIndex, out hallIndex, out sessionIndex);

            if (sessionIndex == -1)
                return;

            Console.WriteLine("Введите через пробел место, которое вы хотите забронировать.\nНапример, координаты первого места - (0 0)");
            int n, m;
            Utility.GetTwoIntsFromConsole(out n, out m);

            films[filmIndex].TryToBookPlace(hallIndex, sessionIndex, n, m);
        }

        static void BuyTicket()
        {
            int filmIndex, hallIndex, sessionIndex;
            GetIndexes(out filmIndex, out hallIndex, out sessionIndex);
            var film = films[filmIndex];
            var hall = film.Halls[hallIndex];
            if (hall.Sessions.Count == 0)
                return;
            var session = hall.Sessions[sessionIndex];


            Console.WriteLine("Введите через пробел место, которое вы хотите купить.\nНапример, координаты первого места - (0 0)");
            int n, m;
            Utility.GetTwoIntsFromConsole(out n, out m);

            if (n > hall.N - 1 || m > hall.M - 1)
            {
                Console.WriteLine("Неправильный ввод: числа вышли за границы зала.");
                return;
            }

            if (films[filmIndex].TryToBuyPlace(hallIndex, sessionIndex, n, m, ref balance, person))
                purchasedTickets.Add(new Ticket
                {
                    FilmName = film.Name,
                    HallName = hall.Name,
                    SessionDT = session.DT,
                    Price = hall.Prices[n, m]
                });
        }

        static void DisplayPurchasedTickets()
        {
            if (purchasedTickets.Count == 0)
            {
                Console.WriteLine("Нет купленных билетов");
                return;
            }

            Console.WriteLine("<Название фильма> <Название зала> <Дата начала фильма> <Цена>");
            foreach (var ticket in purchasedTickets)
            {
                Console.WriteLine($"<{ticket.FilmName}> <{ticket.HallName}> <{ticket.SessionDT}> <{ticket.Price}>");
            }
        }

        static void DisplayBookInfo()
        {
            int filmIndex, hallIndex, sessionIndex;
            GetIndexes(out filmIndex, out hallIndex, out sessionIndex);
            films[filmIndex].Halls[hallIndex].Sessions[sessionIndex].DisplayBookInfo();
        }
    }
}