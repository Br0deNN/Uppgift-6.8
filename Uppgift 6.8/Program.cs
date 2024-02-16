using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal du vill undersöka");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Antalet primtal mindre än {x} är {Mindreän(x)}");


    }
    static bool Primtal(int x)
    {
        int delx = 0;
        for (int i = 2; i < x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }
        return true;
        
    }
    static int Mindreän(int y)
    {
        int antal = 0;

        for (int i = 2; i < y; i++)
        {
            if (Primtal(i))
            {
                antal++;
            }
        }

        return antal;
    }
}