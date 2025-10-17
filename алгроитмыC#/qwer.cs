using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gg
{class qwer: pro
    {
        public static void speed()
        {
            decimal[] obj = new decimal[10000000];
            Console.WriteLine("НАЧИНАЮ");
            decimal count = 10000000;
            for (var i = 0; i < count; i++)
            {
obj[i] = i;
            }
            Console.WriteLine("ДОБАВЛИ!");
           decimal sum = 0;
            for (var j = 0; j < count; j++)
            {
                sum += obj[j];   
            }
            Console.WriteLine("ПРОЧИТАЛ!  " + sum);
        }



    }

}

