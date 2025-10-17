using System;
namespace gg { 
    class Program : algor
    {
       public static List<string> sql = new List<string>
        {
            "й","ц","у","к","е", "н", "г", "ш", "щ", "з", "х", "ъ",
            "ф", "ы", "в", "а", "п", "р", "о", "л", "д", "ж", "э",
            "я", "ч", "с", "м", "и", "т", "ь", "б", "ю", "1", "2",
            "3", "4", "5", "6", "7", "8", "9", "0", "попа", "грязь", "ваня"
        };
        static void Main()
        {
          /*  procent();


            speed();
            int[] puz = [4, 31, 1, 45, 6, 8, 9 ,10 , 42]; 
         int n = puz.Length;
            for (int i = 0; i < n - 1; i++)
            {     
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (puz[j] < puz[j + 1])
                    {
                        int fly = puz[j];
                        puz[j] = puz[j + 1];
                        puz[j + 1] = fly;

                    }
                }
            }
            foreach ( var ii in puz)
            {
                Console.WriteLine(ii + "  ------------------");
            }
            PuzirikSortir([4,32,2,1,6]);
            Console.WriteLine("введи число и мы разобьём его на части");
            int bb = Convert.ToInt32(Console.ReadLine());
            
            // Тестируем функцию
            List<int> change = GiveChange(bb);
            Console.WriteLine( string.Join(", ", change));
            // Вывод: [10, 10, 10, 1, 1]

            */
            vi();
        
            
          
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
      public static void vi()
        {while(true)
            {

           
            Console.WriteLine("q - поиск букв в твоем слове , w - Search.228 , p - процент, s - пузырьковая сортировка, m - разбить на части,  ");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    Console.Clear();
                    poisk();
                    break;
                case ConsoleKey.W:
                    Console.Clear();
                    Search();
                    break;
                case ConsoleKey.P: 
                        Console.Clear();
                        procent();
                        break; 
                case ConsoleKey.S:
                    Console.Clear();
                        
                        //PuzirikSortir();
                        break;
                        case ConsoleKey.M:
                            Console.Clear();
                        Console.WriteLine("введи число и мы разобьём его на части");
                        int bb = Convert.ToInt32(Console.ReadLine());

                        // Тестируем функцию
                        List<int> change = GiveChange(bb);
                        Console.WriteLine(string.Join(", ", change));
                        break;
                    
                    default:
                    Console.Clear();
                  vi();
                    break;
            }
            }
        }
        public static void poisk()
        {
            bool? ggg = false;
            //    p = str(input(""))
            Console.WriteLine("введи слово");
            string a = Console.ReadLine();
            Console.WriteLine("введи букву для определения есть ли она в слове");
            char b = Console.ReadLine()[0];
            //string[] a = ["a", "b", "c", "d", "i", "f", "g"];
            foreach (char i in a)
            {
                if (i == b)
                {
                    Console.WriteLine(i + ", есть в слове");
                    ggg = true;
                    System.Threading.Thread.Sleep(2000);
                  Console.Clear() ;
                    break;
                
                }

            }
            if (ggg != true)
            {
                Console.WriteLine("такой буквы нету");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }

        }
        public static void Search()
        {
          List<string> d = new List<string>();
          string? словоМас = null;
           
            Console.WriteLine("Q   добавить слово, P поиск");  
            var k = Console.ReadKey();
            switch (k.Key)
            {
                case ConsoleKey.Q:
                    Console.Clear();
                    Console.WriteLine("Введи слово которое надо добавить");
                    string ad = Console.ReadLine();
                   foreach(var ii in ad)
                    {

                        sql.Add(ii.ToString());
                    }
                   
                        sql.Add(ad);
                
                    break;
                case ConsoleKey.P:
                    Console.Clear();
                 Console.WriteLine($"Введи:");    
                    string ser = Console.ReadLine();
                    foreach (var ff in sql)
                    {
                        foreach (var слово in ser)
                        {
                            if(ff == слово.ToString())
                            {
                                Console.WriteLine("найдено: ");// ЧТО ТЫ ЗДЕСЬ НАПИСАЛ?

                                словоМас += слово;
                            
                            }
                        else if (ff == словоМас)
                            {
                                Console.WriteLine("найдено: "+ ff);
                            }
                      
                        
                        }
                       
                     //   d.Add(ff.ToString());
                    //    Console.WriteLine(ff);
                    }
                    //string firB = ser[0];
                    /*    char twoB = ser[1];
                        char threeB = ser[2];
                        char fourB = ser[3];
                        char fivB = ser[4];
                        char sixB = ser[5];*/
                    foreach (var i in sql)
                    {
                        //  Console.WriteLine(d);
                        if (i == ser)
                        {
                            Console.WriteLine("найдено: " + i);
                        }


                    }
                
                    break;

            }
           





   
        
        
        
        
        }

        
    }

}
