using System.Collections.Generic;

namespace CinemaProjectHW1.Models
{
    public abstract class BaseFilm
    {
        public abstract string Name { get; set; }

        public abstract string AgeLimit { get; set; }

        public abstract int HallsCount { get; set; }

        public abstract List<Hall> Halls { get; set; }

        public abstract void InitHalls();
    }
}