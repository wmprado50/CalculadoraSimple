using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPorConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numero1=0, numero2=0, suma, resta, multi, divi, modu;
            Console.WriteLine("Ingresa el numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multi = numero1 * numero2;
            divi = numero1 / numero2;
            modu = numero1 % numero2;

            Console.WriteLine("Suma=  "+ suma);
            Console.WriteLine("Resta=  " + resta);
            Console.WriteLine("Multi=  " + multi);
            Console.WriteLine("Divi=  " + divi);
            Console.WriteLine("Modulo= " + modu);
            Console.WriteLine("El programa ha finalizado");
            Console.WriteLine("ESTA ES UNA PRUEBA DE MODIFICACION");
            Console.ReadLine();
        }
    }
}
