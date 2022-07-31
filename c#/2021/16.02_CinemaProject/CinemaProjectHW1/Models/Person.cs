using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectHW1.Models
{
    public class Person : IPerson
    {
        public string FIO { get; set; }

        public int SpentAmount { get; set; }
    }
}