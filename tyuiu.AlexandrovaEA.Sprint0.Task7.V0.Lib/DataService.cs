using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tyuiu.AlexandrovaEA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AddArr(int[] num1, int[] num2)
        {
            int[] resArr = new int[5];
            for(int i = 0; i < resArr.Length; i++)
            {
                resArr[i] = num1[i] + num2[i];
            }
            return resArr;
        }
    }
}
