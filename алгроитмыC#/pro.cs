using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
     class pro
    {  public static void procent()
        {
            double mesproc;
            Console.WriteLine("Введи годовой процент");
            int proc = Convert.ToInt32(Console.ReadLine());
            double mec = proc / 12 * 0.01;
         
           
           
                Console.WriteLine(mec);
                //mec *= 0,01;
                Console.WriteLine("Введи твои деньги которые лежать под процентами");
                double chislo = Convert.ToDouble(Console.ReadLine());


            if (mec == 0)
            {
                Console.WriteLine();
            }
            else
            {
               mesproc = chislo * mec;
                Console.WriteLine("Месячные поступления" + mesproc);
          
            
            }

            double godproc = chislo * (proc * 0.01);
               
                Console.WriteLine("Годовые поступления" + godproc);
            if (mec == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Если вы хотите узнать точую информацию то надмите 'ENTER' ");
                Console.ReadLine();
                for (int i = 0; i <= 12;i++)// 12 повторений
                {
                    mesproc = chislo * mec;
                    chislo += mesproc;

                }
                mesproc = chislo * mec;
                Console.WriteLine("Через год у вас будет " + chislo + " и " + mesproc + " в месяц ");
                Console.WriteLine("$ИНФОРМАЦИЯ МОЖЕТ БЫТЬ НЕ СУПЕР ТОЧНОЙ НЕ ДОВЕРЯЙТЕ ЕЙ");
            }





        }
       



    }
}
