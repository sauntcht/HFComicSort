using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFComicSort
{
    internal class Comic
    {
        public string Name { get; set; }    
        public int Issue { get; set; }

        public override string ToString() => $"{Name} Issue # {Issue}";

        public static readonly IEnumerable<Comic> Catalog = new List<Comic>
        {
            new Comic {Name = "Johnny America vs Pinko", Issue = 6},
            new Comic {Name = "Darkwing Dunc", Issue = 23},
            new Comic {Name = "The Cleaner", Issue = 12},
            new Comic {Name = "Chunsler Dane and the Case of the Winkled Dad", Issue = 92},
            new Comic {Name = "Lamce Armstroung", Issue = 24},
            new Comic {Name = "Batman: A Real Fatty Jerk", Issue = 7},
        };
        public static readonly IReadOnlyDictionary<int, decimal> Prices = new Dictionary<int, decimal> 
        {
            {6, 3600m },
            {23, 4300m },
            {12, 3000m },
            {92, 3300m },
            {24, 6500m },
            {7, 334500m },
        };


    }
}
