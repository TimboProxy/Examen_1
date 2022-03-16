using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Dados
{
    public class Dados
    {
        public int Random()
        {
            int Dado1 = new Random().Next(1, 7);
            int Dado2 = new Random().Next(1, 7);
            int total = Dado1 + Dado2;
            Console.WriteLine("Puntos del Dado 1: " + Dado1);
            Console.WriteLine("Puntos del Dado 2: " + Dado2);
            Console.WriteLine("Puntos totales: "+ total);
            return total;
        } 
        
    }
}
