using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using алгроитмыC_;

namespace gg
{
    class algor: qwer
    {
        public static void PuzirikSortir(int[] name)
        {
            int n = name.Length;
        // public static List<int> = name;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (name[j] < name[j + 1])//  >
                    {
                        //    name[j]  name[j +1] = name[j + 1]  name[j];
                        int temp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp;
                  
                    }

                }
            }

            foreach ( var el in name)
            {
                Console.WriteLine(el);
            }


        }
   
          

            public static List<int> GiveChange(int amount)
            {
                // Монеты в порядке убывания (жадный алгоритм)
                int[] coins = { 5000, 1000, 500, 100, 50, 10, 5, 1 };
                List<int> result = new List<int>();

                // Проходим по всем монетам от самой крупной к самой мелкой
                foreach (int coin in coins)
                {
                    // Пока сумма больше или равна текущей монете
                    while (amount >= coin)
                    {
                        amount -= coin;       // Уменьшаем сумму на номинал монеты
                        result.Add(coin);     // Добавляем монету в результат
                    }
                }

                return result;
            }

           
            
               
        
    
    
    }
}
