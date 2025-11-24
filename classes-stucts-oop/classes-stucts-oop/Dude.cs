using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_stucts_oop
{
    internal class Dude
    {
        public string name;
        public int experience = 0;

        public Dude()
        {
            Reset();
        }

        public Dude(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Dude: " + this.name + " - " + this.experience + " EXP");
        }

        public void Reset()
        {
            this.name = "Not Assigned";
            this.experience = 0;
        }
    }
}
