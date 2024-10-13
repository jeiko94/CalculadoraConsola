static void Main(string[] args)
{
    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("calculadora de consola.");
        Console.WriteLine("Seleccione una operación: ");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Salir");

        int opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                RealizarOperacion("sumar");
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }
}

