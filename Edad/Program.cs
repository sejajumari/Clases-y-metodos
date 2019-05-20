using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese su edad ");

            int salida;
            var edad = Console.ReadLine();
            var result = int.TryParse(edad, out salida);
            if (result == true)
            {
                Console.Write("El valor se puede convertir");
                salida = int.Parse(edad);
            }
            else
            {
                Console.Write("No se puede convertir");
            }
            Console.ReadLine();














        }
    }
}
