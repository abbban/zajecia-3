using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "wojtek";
            string imieGraczaB = "pawelek";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3] {
             { '1', '2', '3' },
             { '4', '5', '6' },
             { '7', '8', '9' }


        };
            Console.WriteLine("wpisz imie gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.WriteLine("wpisz imie gracza B: ");
            imieGraczaB = Console.ReadLine();
            
          
            


        }
    }
}
