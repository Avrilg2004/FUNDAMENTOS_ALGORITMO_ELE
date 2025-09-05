using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();
            Console.WriteLine($"\n{nombre}, bienvenido al curso de fundamentos de algoritmo de {carrera}");
        }
        static void ejer2()
        {
            Console.WriteLine("\"Elena\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese num1: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese mun2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = x / y ;

            Console.WriteLine("Suma: "+(x + y));
            Console.WriteLine("resta: " + (x - y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("División: " + divi);
        }
        
      
    }
}
