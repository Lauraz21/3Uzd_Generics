using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Uzd_Generics
{
    public static class Print
    {
        public static void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine($"reiksme1: {value1} \nreiksme2: {value2}");

        }
    }
}
