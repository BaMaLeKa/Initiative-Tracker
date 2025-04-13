using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{
    public enum STATE
    {
        ALIVE = 0,
        STUNNED,
        DEAD
    }

    public class Character : IComparable<Character>
    {
        public String name { get; set; }
        public int hp { get; set; }
        public int ini { get; set; }
        public STATE state { get; set; }

        public int CompareTo(Character other)
        {
            if (other.ini > this.ini)
                return 1;
            else
                return 0;
        }
    }
}
