using System;
using PrimeFactorClassLib;
namespace PrimeFactorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactor pf = new PrimeFactor();
            Console.WriteLine(pf.PrimeCalc(546));
        }
    }
}
