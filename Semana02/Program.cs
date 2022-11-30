using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese coordenada x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese coordenada y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("punto A: (" +x1+ ","+y1+")");
            Console.WriteLine(" ");

            Console.Write("Ingrese coordenada x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese coordenada y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("punto B: (" + x2 + "," + y2 + ")");
            Console.WriteLine(" ");

            Console.Write("Ingrese coordenada x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese coordenada y3: ");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("punto C: (" + x3 + "," + y3 + ")");
            Console.WriteLine(" ");

            Console.Write("Ingrese coordenada x4: ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese coordenada y4: ");
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine("punto D: (" + x4 + "," + y4 + ")");
            Console.WriteLine(" ");

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.x1 = x1;
            rectangulo.y1 = y1;
            rectangulo.x2 = x2;
            rectangulo.y2 = y2;
            rectangulo.x3 = x3;
            rectangulo.y3 = y3;
            rectangulo.x4 = x4;
            rectangulo.y4 = y4;

            Console.WriteLine("eL area del rectangulo es: " + rectangulo.Area() + " mi King");
            Console.Read();
        }
    }
}
