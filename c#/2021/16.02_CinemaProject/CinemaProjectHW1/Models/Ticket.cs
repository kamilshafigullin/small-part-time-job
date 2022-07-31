using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectHW1.Models
{
    public class Ticket
    {
        public string FilmName { get; set; }

        public string HallName { get; set; }

        public DateTime SessionDT { get; set; }

        public int Price { get; set; }
    }
}