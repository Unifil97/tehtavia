using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huutokauppa_ali
{

    class Program
    {
        private static void  Aloitus(List<string> tuote, List<int> hinta, out int i, out int x, out int tavoite)
        {
            Console.WriteLine("Anna tavoite ");          //kysely 
            tavoite = int.Parse(Console.ReadLine());
            Console.Write("Kuinka monta tuotetta ");
            x = int.Parse(Console.ReadLine());



            for (i = 0; i < x; i++)

            {
                Console.Write("Anna tuotteen nimi  :");  //tuotteet ja hinnat talletetaan listaan
                tuote.Add(Console.ReadLine());
                Console.Write("Anna tuotteen hinta:");
                hinta.Add(Convert.ToInt32(Console.ReadLine()));
                
            }
            for (i = 0; i < tuote.Count; i++)
            {
                Console.WriteLine("\ttuotteet  " + tuote[i] + " : hinta " + hinta[i] + "e");// näytetään tuotteet ja hinnat

            }
        }
    

            static void Main(string[] args)
            {

            List<string> tuote = new List<string>(); /*Lista myytävistä tuotteista*/
            List<int> hinta = new List<int>();/*Lista myytävien tuotteiden lähtöhinnasta*/
            List<int> loppusum = new List<int>();//Lista korkein huuto + lähtöhinta


                Random b = new Random();

                string kallein = "";
                int i, x;
                int tavoite, huuto, sum = 0, korotus = 0, tav, loppu, ylitys = 0, myy = 0, paikka = 0;
                int min = int.MaxValue, max = int.MinValue, maxValue = int.MinValue;
                Aloitus(tuote, hinta, out i, out x, out tavoite);
                Console.WriteLine();

                Console.WriteLine();

                for (paikka = 0; paikka < hinta.Count; paikka++)
                {


                    Console.WriteLine();

                    Console.WriteLine("Huuda tuotetta : " + tuote[paikka]);

                    huuto = b.Next(2, 6); //arvotaan huudot 1-4

                    //huutosilmukka
                    for (i = 1; i < huuto; i++)

                    {

                        korotus = b.Next(5, 101);//arvotaan huuto 5-100
                        min = Math.Min(min, korotus);// suurin ja pienin huuto
                        max = Math.Max(max, korotus);

                        Console.WriteLine(i + " Huuto : " + korotus);

                    }  

                    sum = hinta[paikka] + max;// hinta+suurin huuto


                    loppusum.Add(sum);

                    Console.WriteLine("Pienin huuto " + min);
                    Console.WriteLine("Suurin huuto " + max);

                    Console.WriteLine();
                    if (max >= min)
                    {
                        Console.WriteLine("Voittoisa huuto " + max);
                        Console.WriteLine("Tuote+huuto on " + sum);


                    }
                    if (paikka != 0)
                    {

                        if (sum < loppusum[paikka - 1])
                        {

                            Console.WriteLine("Pienempi kuin edellinen huuto ");
                        }

                        if (sum > loppusum[paikka - 1])
                        {

                            Console.WriteLine("Suurenpi kuin edellinen huuto  ");
                        }
                        if (sum == loppusum[paikka - 1])
                        {
                            Console.WriteLine("sämä hinta ");
                        }


                    }

                    if (loppusum.Sum() != 0)
                    {
                        myy++;
                        Console.WriteLine("Myyty nyt " + myy);
                    }

                    Console.WriteLine("------------------------");
                    Console.WriteLine();
                    Console.WriteLine();

                    min = 101;
                    max = 4;

                    if (sum > maxValue)
                    {

                        maxValue = sum;
                        kallein = tuote[paikka];

                    }

                }

                loppu = loppusum.Sum();

                tav = tavoite - loppu;
                ylitys = loppu - tavoite;
                if (tavoite > loppu)
                {
                    Console.WriteLine("Kokonais huudot " + loppu);
                    Console.WriteLine("Tavoittesta jäljessä " + tav);
                }


                else
                {

                    Console.WriteLine("Kokonais huudot " + loppu);
                    Console.WriteLine("Tavoite saavutettu plupsaa tuli " + ylitys);
                }


                Console.WriteLine("kallein tuote: {0} hinta: {1}", kallein, maxValue);

                Console.WriteLine("\nPaina jotain ...");

                Console.ReadKey();
            }           
        
    }
}
