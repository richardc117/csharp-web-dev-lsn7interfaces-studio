using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string DiscType{ get; set; }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public int Capacity { get; set; }

        public float FreeSpace { get; set; }
        public List<string> Data = new List<string>();

        public BaseDisc(string discType, int capacity, int minSpeed, int maxSpeed)
        {
            DiscType = discType;
            Capacity = capacity;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
            FreeSpace = capacity;
        }


        public void SpinDisc()
        {
            Console.WriteLine($"A {DiscType} spins at a rate of {MinSpeed} - {MaxSpeed} rpm.");
        }

        public void WriteData(string data)
        {
            Data.Add(data);
            FreeSpace -= data.Length;
        }

        public void ReadData()
        {
            foreach (string item in Data)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }
    }
}
