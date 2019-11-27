using System;

namespace laiva_ali
{
    class Program
    {

        static void Taulu(int x, int y/*, int v, int c*/)
         
        {
           
            int[,] grid = new int[6, 6];  /*taulukko 5*5*/
            grid[x, y] = 1;               /* oma laiva = 1*/            
            //grid[x, y + 1] = 1;
            //grid[v, c] = 2;

            for (int i = 1; i < grid.GetLength(0); i++)
            {                                                           /*Taulukko ja tulostus*/
                for (int j = 1; j < grid.GetLength(1); j++)
                    Console.Write(grid[i, j]);


                Console.WriteLine();

            }


        }

        static void Taulu1(int w, int r)
      
        {
            int[,] grid1 = new int[6, 6];

            grid1[w, r] = 2;   /*koneen laivan saa piiloon laittamalla tähän 0*/
                             //grid1[w, r + 1] = 2;
            
            for (int i = 1; i < grid1.GetLength(0); i++)

            {
                for (int j = 1; j < grid1.GetLength(1); j++)                   
                Console.Write(grid1[i, j]);              
                Console.WriteLine();              
            }
            
        }
    
        
        static void Main(string[] args)
        
        {
            
            Console.WriteLine("Tervetuloa peliin");
            
            Console.WriteLine("Anna suunta x "); /*kysytään käyttäjältä laivan paikkaa*/
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna suunta y ");
            int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Anna suunta x ");
            ////int v = int.Parse(Console.ReadLine());
            ////Console.WriteLine("Anna suunta y ");
            ////int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Laivat on " + x + "," + y );
           
            Taulu(x, y);
           
            Random rand = new Random();                 /*koneen laiva*/
            int w = rand.Next(1, 5);
            int r = rand.Next(1, 5);
            Console.WriteLine("\n koneen laivat on " + w + "," + r);
            
            Taulu1(w, r);
            bool osu = true;
           
            while (osu)

            {

                Console.WriteLine("ammuhan johonki");
                Console.WriteLine("Anna suunta x ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna suunta y ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(" ammuit " + a + "," + b);
                Console.Clear();

                if ((w == a) && (r == b))
                   
                    
                {
                   
                    Console.WriteLine("osuit pelaaja voitti");
                   
                    Console.ReadLine();
                    Environment.Exit(0);

                }

                //else if ((w == a) && (r + 1 == b))

             
                    else 
                {
                   
                    Console.WriteLine("ohi");
                }
                
                Console.WriteLine(" Kone ampu");
                Random uusi = new Random();
                int ko1 = rand.Next(1, 5);
                int ko2 = rand.Next(1, 5);
                Console.WriteLine(" " + ko1 + " , " + ko2);


                if ((ko1 == x) && (ko2 == y))

                {

                    Console.WriteLine(" poks");
                    Console.WriteLine("Tietsikka voitti");
                    Console.ReadLine();
                    osu = false;
                }


                else
                {

                    Console.WriteLine(" ohi män");
                    osu = true;
                }
               
                Console.WriteLine("Pelaajan taulu");
                Taulu(x, y);
                Console.WriteLine();
                Console.WriteLine("Koneen taulu");
                Taulu1(w, r);


                Console.ReadKey();
            }

        }

        
    }
}
