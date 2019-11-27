using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuutta_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollari;
            double punta;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Anna eurot ");
            double euro = Convert.ToDouble(Console.ReadLine());
            dollari = euro * 1.12;
            punta = euro * 0.85;
            


            Console.Write("Haluatko puntina vai dollareina: ");
            char raha = Console.ReadKey().KeyChar;
            
            if (raha == 'p')
            {
                Console.WriteLine("\n{1} puntaa",euro,punta);
            }

            if (raha == 'd')
            {
                Console.WriteLine("\n{1} dollaria", euro, dollari);
            } 

                Console.ReadKey();
        }
    }
}
