using System;

namespace _6._3.Task._6._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();

            while (true)
            {
                Console.Write("The number of passengers is equal: ");
                if (int.TryParse(Console.ReadLine(), out int result)) { } 

                    bus.PrintStatus(result);       
            }   
        }

        class Bus
        {
            public int? Load;
            
            public void PrintStatus(int value)

            {
                Load = value;
                if (Load.HasValue && Load>0)
                {
                    Console.WriteLine("Passangers: " + Load.Value);
                }
                else  Console.WriteLine("Bas is empty");
                
            }
        }
    }
}
