
using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Negocio
{
    public class Resta: OperacionBase
    {
        public override double Calcular()
        {
            return Numero1 - Numero2;
        }
    }
}
