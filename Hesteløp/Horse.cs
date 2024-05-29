using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horseracer
{
    internal class Horse
    {
        private string Name;
        private int Speed;
        public int Distance;

        public Horse(string name, int speed, int distance)
        {
            Name = name;
            Speed = speed;
            Distance = distance;
        }

        public string getName()
        {
            return Name;
        }

        public int getSpeed()
        {
            return Speed;
        }

        public int getDistance()
        {
            return Distance;
        }

        public void Feed()
        {
            Console.Clear();
            Console.WriteLine($"{Name} ate food.");
            Console.ReadKey(true);
        }

        public void Wash()
        {
            Console.Clear();
            Console.WriteLine($"{Name} feels refreshed.");
            Console.ReadKey(true);
        }
    }
}
