using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Negocio
{
    public class Calculadora
    {
        public double EjecutarOperacion(OperacionBase operacion)
        {
            return operacion.Calcular();
        }
    }
}
