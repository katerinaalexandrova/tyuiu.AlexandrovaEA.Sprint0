using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.AlexandrovaEA.Sprint0.Task7.V0.Lib;

namespace tyuiu.AlexandrovaEA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Александрова Е. А. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Александрова Е. А. | ИСПБ-23-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int[] ArrNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1: ");
            for(int i = 0; i < ArrNums1.Length; i++)
            {
                Console.Write(ArrNums1[i] + ", ");
            }
            Console.WriteLine();
            int[] ArrNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2: ");
            for (int i = 0; i < ArrNums2.Length; i++)
            {
                Console.Write(ArrNums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ArrNums1.Length == ArrNums2.Length)
            {
                int[] resArr = DataService.AddArr(ArrNums1, ArrNums2);
                Console.WriteLine("Сумма элементов массива равна: ");
                for (int i = 0; i < resArr.Length; i++)
                {
                    Console.Write(resArr[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные данные массива имеют разное количество элементов!");
            }
            Console.ReadKey();
        }
    }
}
