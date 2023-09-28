using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.AlexandrovaEA.Sprint0.Task6.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элемнтов массива = " + DataService.AddArr(Arr));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstrArr(Arr));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultArr(Arr));
            Console.ReadKey();
        }
    }
}
