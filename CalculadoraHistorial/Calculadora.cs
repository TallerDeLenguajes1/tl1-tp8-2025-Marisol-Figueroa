using System;
using System.Collections.Generic;

public class Calculadora
{
    private double resultadoActual;
    private List<Operacion> historial;

    public Calculadora()
    {
        resultadoActual = 0;
        historial = new List<Operacion>();
    }

    public double ResultadoActual => resultadoActual;

    public void AplicarOperacion(double valor, TipoOperacion tipo)
    {
        if (tipo == TipoOperacion.Limpiar)
        {
            historial.Add(new Operacion(resultadoActual, 0, tipo));
            resultadoActual = 0;
        }
        else
        {
            var operacion = new Operacion(resultadoActual, valor, tipo);
            resultadoActual = operacion.Resultado;
            historial.Add(operacion);
        }
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("\n--- HISTORIAL DE OPERACIONES ---");
        if (historial.Count == 0)
        {
            Console.WriteLine("No hay operaciones registradas.");
        }
        else
        {
            foreach (var op in historial)
            {
                Console.WriteLine(op);
            }
        }
    }
}
