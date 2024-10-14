

namespace CalculadoraConsola.Negocio
{
    public class Operaciones
    {
        public abstract class OperacionBase
        {
            public double Numero1 { get; set; }
            public double Numero2 { get; set; }

            public abstract double Calcular();

        }
    }
}
