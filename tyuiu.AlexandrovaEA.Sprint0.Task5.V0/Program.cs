using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.AlexandrovaEA.Sprint0.Task5.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Add(1, 5));
            Console.WriteLine("A - B = " + DataService.Sub(10, 5));
            Console.WriteLine("A * B = " + DataService.Mult(2, 5));
            Console.WriteLine("A / B = " + DataService.Div(9, 3));
            Console.ReadKey();
        }
    }
}
