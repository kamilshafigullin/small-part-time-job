using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectHW1.Models
{
    public class Session
    {
        public int[,] Prices { get; set; }
        public int[,] BookInfo { get; set; }

        public DateTime DT { get; set; }

        int N;
        int M;

        public Session(int N, int M)
        {
            this.N = N;
            this.M = M;
            BookInfo = new int[N, M];
        }

        public void BookPlace(int x, int y)
        {
            BookInfo[x, y] = 1;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("0 - свободно, 1 - забронировано, 2 - куплено");
            for (int i = 0; i < N; i ++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(BookInfo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int GetSoldPlacesCount()
        {
            int r = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (BookInfo[i, j] == 2)
                        r += 1;
                }
            }

            return r;
        }

        public int GetFreePlacesCount()
        {
            int r = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (BookInfo[i, j] == 0)
                        r += 1;
                }
            }

            return r;
        }

        public int GetRevenue()
        {
            int r = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (BookInfo[i, j] == 2)
                        r += Prices[i, j];
                }
            }

            return r;
        }
    }
}