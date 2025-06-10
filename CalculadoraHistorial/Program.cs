// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public void inicio()
    {
        Calculadora calc = new Calculadora();
        int opcion;

        do
        {
            Console.WriteLine($"\nResultado actual: {calc.ResultadoActual}");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Ver historial");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    EjecutarOperacion(calc, TipoOperacion.Suma);
                    break;
                case 2:
                    EjecutarOperacion(calc, TipoOperacion.Resta);
                    break;
                case 3:
                    EjecutarOperacion(calc, TipoOperacion.Multiplicacion);
                    break;
                case 4:
                    EjecutarOperacion(calc, TipoOperacion.Division);
                    break;
                case 5:
                    calc.AplicarOperacion(0, TipoOperacion.Limpiar);
                    break;
                case 6:
                    calc.MostrarHistorial();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0);
    }

    private void EjecutarOperacion(Calculadora calc, TipoOperacion tipo)
    {
        Console.Write("Ingrese el valor: ");
        if (double.TryParse(Console.ReadLine(), out double valor))
        {
            calc.AplicarOperacion(valor, tipo);
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }
}

