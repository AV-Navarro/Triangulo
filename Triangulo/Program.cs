using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa en C# que solicite un símbolo y un ancho para pintar un triángulo de ese ancho y alto utilizando ese número para dibujarlo
            Console.WriteLine("Introduce el número que se usará en el triángulo:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el ancho (y altura) inicial del triángulo:");
            int ancho = Convert.ToInt32(Console.ReadLine());

            int alto = ancho;

            for (int fila = 0; fila < alto; fila++)
            {

                for (int columna = 0; columna < ancho; columna++)
                {
                    Console.Write(x);
                }


                Console.WriteLine();
                ancho--;
            }
        }
    }
}

