using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsola
{
    public class Operaciones
    {
        static double Suma(double a, double b)
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
                return 0;
            }
        }
    }
}
