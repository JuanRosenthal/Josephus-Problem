using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double anzahl_Soldaten;
            double groeßte_basis;
            double Loesungsmenge;
            double count1 = 1;
            double Teilbarkeit = 0;

            Console.WriteLine("Wie viel Soldaten sind da?");
            anzahl_Soldaten = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            
            while (count1 < anzahl_Soldaten)
            {
                count1= count1*2;
                Teilbarkeit++;            
            }
            if(Math.Pow(2,Teilbarkeit)==anzahl_Soldaten)
            {
                Console.WriteLine("Du musst der erste Soldat sein, um zu gewinnen");
            }
            else
            {
                groeßte_basis = Math.Pow(2, (Teilbarkeit - 1));
                Loesungsmenge = 2 * (anzahl_Soldaten -groeßte_basis) + 1;
                Console.WriteLine("Du musst der {0} Soldat sein, um zu gewinnen",Loesungsmenge);
            }            
            Console.ReadKey();
            
        }
    }
}
