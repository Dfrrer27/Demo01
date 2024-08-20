using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vértice A - x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vértice A - y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vértice B - x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vértice B - y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vértice B - x2: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vértice B - y2: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vértice B - x2: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vértice B - y2: ");
            double y4 = Convert.ToDouble(Console.ReadLine());

            double AB = Raiz(x1, y1, x2, y2);
            double BC = Raiz(x2, y2, x3, y3);
            double CD = Raiz(x3, y3, x4, y4);
            double AD = Raiz(x4, y4, x1, y1);

            Console.WriteLine("Distancia de AB: ");
            Console.WriteLine(AB);
            Console.WriteLine("Distancia de BC: ", BC);
            Console.WriteLine(BC);
            Console.WriteLine("Distancia de CD: ", CD);
            Console.WriteLine(CD);
            Console.WriteLine("Distancia de AD: ", AD);
            Console.WriteLine(AD);

            double base1, base2;
            if (AB == CD && BC == AD)
            {
                base1 = AB;
                base2 = BC;
            }
            else if (AB == CD)
            {
                base1 = AB;
                base2 = BC;
            }
            else
            {
                base1 = BC;
                base2 = AD; 
            }

            double Area = base1 * base2;
            double Perimetro = 2 * (base1 * base2);

            Console.WriteLine("BASE: ");
            Console.WriteLine(base1);

            Console.WriteLine("ALTURA: ");
            Console.WriteLine(base2);

            Console.WriteLine("Área del Rectángulo: ");
            Console.WriteLine(Area);

            Console.WriteLine("Perimetro del Rectángulo: ");
            Console.WriteLine(Perimetro);

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


            //Persona persona = new Persona

            //{
            //    Nombres = "Diego",
            //    Apellidos = "Ferrer"
            //};

            //persona.AsignarNombresCompletos();

            //Console.WriteLine(persona.NombresCompletos);

            //Console.WriteLine("------------------------------------------------------------");

            //Profesor profesor = new Profesor
            //{
            //    Nombres = "Diego",
            //    Apellidos = "Ferrer",
            //    Sueldo = 15000
            //};

            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------------------------");

            //Estudiante estudiante = new Estudiante
            //{
            //    Nombres = "Carlos",
            //    Apellidos = "Damacen",
            //    Codigo = 102755
            //};

            //estudiante.AsignarInformarcionCompleta();

            //Console.WriteLine(estudiante.InformarcionCompleta);

            //Console.WriteLine("------------------------------------------------------------");
            Console.Read(); //Le da un pare
        }

        static double Raiz(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2 + Math.Pow((y2 - y1), 2)));
        }

        static void Rectangulo() 
        {
            
        }
    }
}
