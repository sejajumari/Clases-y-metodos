using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuacion
{
    class Program
    {
        static void Main(string[] args)
        {


            int salidacn;
            int salidabn;
            int salidaan;

            Console.Write("ingrese primer número  ");
            var a = Console.ReadLine();
            var aresult = int.TryParse(a, out salidaan);
            Console.Write("ingrese segundo número ");
            var b = Console.ReadLine();
            var bresult = int.TryParse(b, out salidabn);
            Console.Write("ingrese tercer número ");
            var c = Console.ReadLine();
            var cresult = int.TryParse(c, out salidacn);

            if ((aresult == true) && (bresult == true) && (cresult == true))
            {
                salidaan = int.Parse(a);
                salidabn = int.Parse(b);
                salidacn = int.Parse(c);
                if ((salidaan == 0) || (salidabn == 0))
                {
                    Console.Write("No se puede realizar la ecuación");
                }
                else
                {


                    var solucion = (salidabn * salidabn) - (4 * (salidaan * salidacn));

                    if (solucion > 0)
                    {
                        double x = -((salidabn) - Math.Sqrt((salidabn) * (salidabn) - (4 * ((salidaan) * (salidacn))))) / (2 * (salidaan));
                        double x2 = -((salidabn) + Math.Sqrt((salidabn) * (salidabn) - (4 * ((salidaan) * (salidacn))))) / (2 * (salidaan));

                        Console.WriteLine($"La ecuacion  negativa es: {x} la ecuacion es positiva {x2}");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("La solución esta dentro del conjunto de los imaginarios");
                        Console.ReadLine();
                    }
                }


            }
            else
            {
                Console.Write("No se pudo realizar la operación ");
            }
            Console.ReadLine();




















        }
    }
}
