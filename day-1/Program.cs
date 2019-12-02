using System;
using System.IO;

namespace day_1
{
  class Program
  {
    static double Part1(string[] modules)
    {
        double totalFuel = 0;
        foreach (string module in modules)
        {
            double weight = Double.Parse(module);
            double fuel = Math.Floor(weight / 3) - 2;
            totalFuel += fuel;
        }
        return totalFuel;
    }

    static double Part2(string[] modules)
    {
        double totalFuel = 0;
        foreach (string module in modules)
        {
            double weight = Double.Parse(module);
            double fuel = Math.Floor(weight / 3) - 2;
            while (fuel > 0) {
                totalFuel += fuel;
                fuel = Math.Floor(fuel / 3) - 2;
            }
        }
        return totalFuel;
    }

    static void Main(string[] args)
    {
      string[] modules = File.ReadAllLines("day-1.txt");

      Console.WriteLine("Part 1: " + Part1(modules));
      Console.WriteLine("Part 2: " + Part2(modules));
    }
  }
}
