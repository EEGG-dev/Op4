namespace HelperLib;

public static class Logic
{
    public static double PedirValorProducto()
    {
        while (true)
        {
            Console.WriteLine("Ingresa el valor del producto: ");
            if (double.TryParse(Console.ReadLine(), out double valor) && valor >= 0)
                return valor;

            System.Console.WriteLine("Valor invalido. Intente nuevamente.");
        }
    }

    public static double PedirImpuesto()
    {
        
        while (true)
        {
            Console.Write("Ingresa el tipo de iva: ");
            if (double.TryParse(Console.ReadLine(), out double porcentaje) && porcentaje >= 0 && porcentaje <= 100)
                return porcentaje;

            System.Console.WriteLine("Porcentaje invalido. Intente nuevamente.");
        }
    }

    public static double CalcularPrecioFinal(double valor, double porcentaje)
    {
        return valor + (valor * porcentaje / 100);
    }

    public static void MostrarPrecioFinal(double precioFinal)
    {
        System.Console.WriteLine($"El precio con impuesto es: {precioFinal}");
    }

    public static bool AskToContinue()
    {
        Console.Write("Do you keep going: ");
        string continueLooping = Console.ReadLine();
        System.Console.WriteLine();

        bool output = (continueLooping == "yes");
        return output;
    }

    public static void MainLogic()
    {
        do
        {
            double valor = PedirValorProducto();
            double impuesto = PedirImpuesto();
            double precioFinal = CalcularPrecioFinal(valor, impuesto);
            MostrarPrecioFinal(precioFinal);
            System.Console.WriteLine();
        } while (AskToContinue());
    }
}
