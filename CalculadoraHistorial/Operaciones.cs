public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public double Resultado
    {
        get
        {
            return operacion switch
            {
                TipoOperacion.Suma => resultadoAnterior + nuevoValor,
                TipoOperacion.Resta => resultadoAnterior - nuevoValor,
                TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
                TipoOperacion.Division => nuevoValor != 0 ? resultadoAnterior / nuevoValor : double.NaN,
                TipoOperacion.Limpiar => 0,
                _ => throw new InvalidOperationException("Operación no válida.")
            };
        }
    }

    public double NuevoValor => nuevoValor;
    public TipoOperacion Tipo => operacion;

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public override string ToString()
    {
        return $"{resultadoAnterior} {OperacionSimbolo()} {nuevoValor} = {Resultado}";
    }

    private string OperacionSimbolo()
    {
        return operacion switch
        {
            TipoOperacion.Suma => "+",
            TipoOperacion.Resta => "-",
            TipoOperacion.Multiplicacion => "*",
            TipoOperacion.Division => "/",
            TipoOperacion.Limpiar => "LIMPIAR",
            _ => "?"
        };
    }
}
