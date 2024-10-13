using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraConsola;

namespace CalculadoraConsola
{
    public class Logica
    {
        Operaciones oper = new Operaciones();
        
        static void RealizarOperacion(string peracion)
        {
            Console.WriteLine("Ingresa un primer numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (peracion)
            {
                case "sumar":
                    resultado = Suma(num2 + num1);
                    break;
            }
        }
    }
}
