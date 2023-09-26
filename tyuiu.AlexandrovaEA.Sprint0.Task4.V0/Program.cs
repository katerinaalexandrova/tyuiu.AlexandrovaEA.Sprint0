using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.AlexandrovaEA.Sprint0.Task4.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Add(1, 5));
            Console.WriteLine(DataService.Sub(10, 5));
            Console.WriteLine(DataService.Mult(2, 5));
            Console.WriteLine(DataService.Div(10, 5));
            Console.ReadKey();
        }
    }
}
