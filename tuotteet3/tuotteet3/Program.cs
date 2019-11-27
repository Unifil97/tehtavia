using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuotteet3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Kuinka monta tuotetta");
            int i, j, x;
            {
                x = int.Parse(Console.ReadLine());
                //tässä x kuvaa oppilaiden lukumäärää,
                //joka kysytään käyttäjältä
                string[] nimet = new string[x];
                int[,] arvosanat = new int[x, 3];
                //Kysytään oppilaan nimi ja arvosanat
                for
                 (i = 0; i < x; i++)
                {
                    Console.Write("Anna tuotteen nimi:");
                    nimet[i] = Console.ReadLine();
                }
                for
                 (j = 0; j > 3; j++)
                {
                    Console.Write("Anna kurssin " + (j + 1) + "arvosana");




                    arvosanat[i, j] = int.Parse(Console.ReadLine());
                }

                for (i = 0; i < x; i++)
                {
                    Console.Write("\nOppilaan " + nimet[i] + " arvosanat:");
                    for (j = 0; j < 3; j++)
                        Console.Write("\t" + arvosanat[i, j]);
                }
            }    Console.ReadKey();
        }
    }
}
