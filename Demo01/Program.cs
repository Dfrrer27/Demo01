using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int area = 0;
            //int perimetro = 0;

            //Rectangulo rectangulo = new Rectangulo();

            //rectangulo.Base = 10;
            //rectangulo.Altura = 20;

            //area = rectangulo.CalcularArea();
            //perimetro = rectangulo.CalcularPerimetro();

            //Console.WriteLine("El area es: ");
            //Console.WriteLine(area);
            //Console.WriteLine("El perimetro es: ");
            //Console.WriteLine(perimetro);


            Persona persona = new Persona

            {
                Nombres = "Diego",
                Apellidos = "Ferrer"
            };

            persona.AsignarNombresCompletos();

            Console.WriteLine(persona.NombresCompletos);

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Hello World"); //Escribe en pantalla
            Console.Read(); //Le da un pare
        }

        static void Rectangulo() 
        {
            
        }
    }
}
