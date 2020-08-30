using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public HairColor HairColor { get; set; }
        public int Strength { get; set; }
        public string Race { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum HairColor
    {
        Blue = 0,
        Black = 1,
        Brown = 2,
        Green = 3,
        Pink = 4,
        White = 5,
        Orange = 6
    }
}
