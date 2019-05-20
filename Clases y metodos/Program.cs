using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
                //Se crea sujeto1 
                Persona sujeto1 = new Persona();

                //Se crea sujeto2 
                Persona sujeto2 = new Persona();

                sujeto1.IngresarPersona(sujeto1);
                sujeto2.IngresarPersona(sujeto2);

                sujeto2.VisualizarPersona(sujeto2);
                sujeto1.VisualizarPersona(sujeto1);

                Console.ReadLine();


            














        }
    }
}
