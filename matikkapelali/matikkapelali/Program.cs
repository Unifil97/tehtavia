using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matikkapelali
{
    class Program
    {
        private static int Taulu()
        {
            Console.WriteLine("taulu 1" + " on plus");
            Console.WriteLine("taulu 2" + " on miinus");
            Console.WriteLine("taulu 3" + " on kerto");
            Console.WriteLine("taulu 4" + " on jako");
            Console.WriteLine("taulu 5" + " on palkinnot");
            Console.WriteLine("taulu 6" + " lopetus");


            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        private static List<int> Teht (List<int> palkinnot,double input,int palkinto,double sum)
            {
            if (sum == input)
            {
                Console.WriteLine("oikein  " + sum);
                Console.WriteLine("Voitit " + palkinto + " kpl");

                palkinto++;
                palkinnot.Add(palkinto);
                return palkinnot;
            }
            else
            {
                Console.WriteLine("Et ossoo laskee ");
                return palkinnot;

            }
        }
        private static int Plus(List<int> palkinnot, Random r,  int palkinto)
        {

            double input;
            double arvo = r.Next(1, 101);
            double arvo1 = r.Next(1, 101);
            double sum = arvo + arvo1;
            Console.WriteLine(arvo + " + " + arvo1);
            Console.WriteLine("Laske summa ");
            input = Convert.ToDouble(Console.ReadLine());


            palkinnot = Teht( palkinnot, input, palkinto, sum);

            return palkinto;

        }

     

        private static int Miinus(List<int> palkinnot,  double input, Random r, int palkinto,  double arvo,  double arvo1,  double sum)
        {
            arvo = r.Next(1, 101);
            arvo1 = r.Next(1, 101);
            sum = arvo - arvo1;
            
            
            Console.WriteLine(arvo + " - " + arvo1);

            Console.WriteLine("Laske erotus ");
            input = Convert.ToDouble(Console.ReadLine());
            palkinnot = Teht(palkinnot, input, palkinto, sum);
          

            return palkinto;
        }
        private static int Kerto(List<int> palkinnot,  double input, Random r, int palkinto,  double arvo,  double arvo1,  double sum)
        {
            arvo = r.Next(1, 101);
            arvo1 = r.Next(1, 101);
            sum = arvo * arvo1;
            Console.WriteLine(arvo + " * " + arvo1);
            Console.WriteLine("Laske tulo ");
            input = Convert.ToDouble(Console.ReadLine());
            palkinnot = Teht(palkinnot, input, palkinto, sum);
         

            return palkinto;
        }
        private static int Jako( List<int> palkinnot,  string k,  double input, Random r, int palkinto, double arvo, double arvo1, double sum)
        {

            sum = 0;
            Console.WriteLine("Haluutko kokonaislukuna k/e");
            k = (Console.ReadLine());

            arvo = r.Next(1, 101);
            arvo1 = r.Next(1, 101);
            if (k == "k")
            {

                sum = arvo / arvo1;
                sum = Math.Floor(sum);

                Console.WriteLine(arvo + " / " + arvo1);
                Console.WriteLine("Laske tulo ");
                input = Convert.ToDouble(Console.ReadLine());
                palkinnot = Teht(palkinnot, input, palkinto, sum);

               
                Console.WriteLine();
            }

           
            if (k == "e")
            {

                sum = arvo / arvo1;
                sum = Math.Round(sum, 2);
                Console.WriteLine(arvo + " / " + arvo1);
                Console.WriteLine("Laske tulo ");
                input = Convert.ToDouble(Console.ReadLine());
                palkinnot = Teht(palkinnot, input, palkinto, sum);

                

            }
            return palkinto;
        }
         

        private static void Palkinnot(List<int> palkinnot)
            {
                Console.WriteLine();
                Console.WriteLine("\nPalkintojen määrä " + palkinnot.Count);
                Console.WriteLine();
            }
        static void Main(string[] args)
        {
            List<int> palkinnot = new List<int>();
            double arvo=0, arvo1=0, sum=0;
            string k="";
            double input=0 ;
            Random r = new Random();
            int palkinto = 1;

            Console.WriteLine(" Tervetuloa matikkapeliin. Siirry valikossa valitsemalla numero");
            
           
            while(true)

            {
                int numero = Taulu();
                Console.Clear();
                switch (numero)


                {

                    case 1:

                        //double arvo, arvo1, sum;
                        palkinto = Plus(palkinnot, r,  palkinto);
                        
                      break;
                        

                    case 2:

                        palkinto = Miinus(palkinnot,  input, r, palkinto,  arvo,  arvo1,  sum);

                        continue;



                    case 3:
                        palkinto = Kerto(palkinnot,  input, r, palkinto,  arvo,  arvo1,  sum);

                        continue;

                    case 4:
                        {
                            palkinto = Jako( palkinnot,  k,  input, r, palkinto,  arvo,  arvo1,  sum);

                            continue;
                        }
                    case 5:
                        {
                            Palkinnot(palkinnot);
                        }

                        continue;
                    case 6:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
                Console.ReadKey();
            }        
     
        }

     
    }
}
