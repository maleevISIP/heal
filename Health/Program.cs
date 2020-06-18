using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health
{
    class Heal
    {
        private double temperatur;
        public double temperaturZnach
        {
            get
            {
                return temperatur;
            }
            set
            {
                if (value < 34)
                    temperatur = 34;
                if (value > 41)
                    temperatur = 41;
                else temperatur = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heal Health = new Heal();
            Health.temperaturZnach = 100;
            Console.WriteLine(Health.temperaturZnach + " (Стандарт -- 41 град.)");
            Health.temperaturZnach = 36.6;
            Console.WriteLine(Health.temperaturZnach);
            Console.ReadKey();
        }
    }
}
