using System;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> rockstars = new Queue<string>();

            rockstars.Enqueue("Paul McCartney");
            rockstars.Enqueue("Elvis Presley");
            rockstars.Enqueue("David Bowie");
            rockstars.Enqueue("Mick Jagger");
            rockstars.Enqueue("Jimi Hendrix");
            
            Console.WriteLine($"Here are your {rockstars.Count()} rockstars");

            foreach (var m in rockstars)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine(rockstars.Contains("Bon Jovi"));
            Console.WriteLine("This rockstar is not in line.");


            string firstStar = rockstars.Peek();
            Console.WriteLine($"{firstStar} is the first rockstar to get through the line.");
            rockstars.Dequeue();
            
            Console.WriteLine($"You have {rockstars.Count} rockstars left in the queue");

        }
    }
}