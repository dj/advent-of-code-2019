using System;
using System.IO;

namespace day_1
{
  class Program
  {
    static double Part1(double[] modules)
    {
      double totalFuel = 0;
      foreach (double weight in modules)
      {
        double fuel = Math.Floor(weight / 3) - 2;
        totalFuel += fuel;
      }
      return totalFuel;
    }

    static double Part2(double[] modules)
    {
      double totalFuel = 0;
      foreach (double weight in modules)
      {
        double fuel = Math.Floor(weight / 3) - 2;
        while (fuel > 0)
        {
          totalFuel += fuel;
          fuel = Math.Floor(fuel / 3) - 2;
        }
      }
      return totalFuel;
    }

    static void Main(string[] args)
    {
      string[] lines = File.ReadAllLines("day-1.txt");
      double[] modules = new double[lines.Length];
      for (int i = 0; i < lines.Length; i++)
      {
        modules[i] = Double.Parse(lines[i]);
      }

      Console.WriteLine("Part 1: " + Part1(modules));
      Console.WriteLine("Part 2: " + Part2(modules));
    }
  }
}
