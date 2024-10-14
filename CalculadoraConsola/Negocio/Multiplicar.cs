

using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Negocio
{
    public class Multiplicar: OperacionBase
    {
        public override double Calcular()
        {
            return Numero1 * Numero2;
        }
    }
}
