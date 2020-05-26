﻿using System;

namespace FormatException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal price = 169.32m;
                Console.WriteLine("The cost is {0:Q2}.", price);
            }
            catch (System.FormatException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
