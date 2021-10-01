using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("LandRover", "RangeRover", "2020",true);

            Console.WriteLine(car1.GetDetailedInfo());
        }
    }
}
