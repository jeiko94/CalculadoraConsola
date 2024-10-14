

using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Negocio
{
    public class Dividir: OperacionBase
    {
        public override double Calcular()
        {

            if (Numero2 != 0)
                return Numero1 / Numero2;
            else
                throw new DivideByZeroException("Error: División por cero.");
        }
    }
}
