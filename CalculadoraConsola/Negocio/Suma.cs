
using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Negocio
{
    public class Suma: OperacionBase
    {
        public override double Calcular()
        {
            return Numero1 + Numero2;
        }
    }
}
