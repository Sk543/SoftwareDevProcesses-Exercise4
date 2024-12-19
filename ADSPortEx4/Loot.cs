using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    class Loot : IComparable
    {
        // Properties of the Loot class
        public string Name { get; set; }
        public double LootValue { get; set; }

        // Constructor to initialize Loot
        public Loot(string name, double lootValue)
        {
            Name = name;
            LootValue = lootValue;
        }

        // CompareTo implementation for sorting by LootValue
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is Loot other)
            {
                return LootValue.CompareTo(other.LootValue);
            }
            throw new ArgumentException("Object is not a Loot");
        }
    }
}
