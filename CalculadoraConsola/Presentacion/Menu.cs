using CalculadoraConsola.Negocio;
using static CalculadoraConsola.Negocio.Operaciones;

namespace CalculadoraConsola.Presentacion
{
    public class Menu
    {
        private Calculadora calculadora = new Calculadora();

        public void MostrarMenu()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("calculadora de consola.");
                Console.WriteLine("Seleccione una operación: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                try
                {
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            RealizarOperacion(new Suma());
                            break;
                        case 2:
                            RealizarOperacion(new Resta());
                            break;
                        case 3:
                            RealizarOperacion(new Multiplicar());
                            break;
                        case 4:
                            RealizarOperacion(new Dividir());
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción invalida.");
                            break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Error inesperado. ");
                }
                


            }
        }

        private void RealizarOperacion(OperacionBase operacion)
        {
            try
            {
                Console.WriteLine("Ingresa el primer numero: ");
                operacion.Numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero: ");
                operacion.Numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = calculadora.EjecutarOperacion(operacion);
                Console.WriteLine($"El resultado es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingresa un numero válido.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error inesperado.");
            }
        }
    }
}
