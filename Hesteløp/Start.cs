using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Horseracer
{
     
    internal class Start
    {
        private List<Horse> horselist = new List<Horse>()
        {
            new Horse("Pedro", 30, 0),
            new Horse("Fridtjof", 20, 0),
            new Horse("Hubert", 25, 0)
        };
        public void Run()
        {
            while (true){
                Console.Clear();
                Console.WriteLine("Welcome to Horseracer! What would you like to do?");
                Console.WriteLine("1. Race");
                Console.WriteLine("2. Feed horse");
                Console.WriteLine("3. Wash horse");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1": 
                        Race();
                        break;
                    case "2":
                        FeedHorse();
                        break;
                    case "3":
                        WashHorse();
                        break;
                }
            }
        }


        public void Race()
        {
            bool raceFinish = false;
            int roundsRaced = 1;
            while (!raceFinish)
            {
                Console.WriteLine($"Round: {roundsRaced}");
                foreach (var horse in horselist)
                {
                    horse.Distance += horse.getSpeed();
                    Console.WriteLine($"{horse.getName()} has ran {horse.getDistance()} km");
                    if (horse.Distance >= 3000)
                    {
                        raceFinish = true;
                        Console.WriteLine($"{horse.getName()} has won the race! It only took him {roundsRaced} rounds");
                    }
                    
                }
                roundsRaced += 1;
            }

            foreach (var horse in horselist)
            {
                Console.WriteLine($"{horse.getName()} ran {horse.getDistance()} km");
            }

            Console.ReadKey();
        }

        public void FeedHorse()
        {
            Console.Clear();
            Console.WriteLine("What horse would you like to feed?");
            for (int i = 0; i < horselist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {horselist[i].getName()}");
            }

            string userInput = Console.ReadLine();
            int horseNumber = Convert.ToInt32(userInput);

            horselist[horseNumber - 1].Feed();
        }

        public void WashHorse()
        {
            Console.Clear();
            Console.WriteLine("What horse would you like to wash?");
            for (int i = 0; i < horselist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {horselist[i].getName()}");
            }

            string userInput = Console.ReadLine();
            int horseNumber = Convert.ToInt32(userInput);

            horselist[horseNumber - 1].Wash();
        }
    }
}
