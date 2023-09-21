public class Curso
{
    public string NombrePersona { get; }
    public double Precio { get; }
    public int DuracionSesiones { get; }
    public int EdadMinima { get; }
    public double Inscripcion { get; }

    public Curso(string nombrePersona, double precio, int duracionSesiones, int edadMinima, double inscripcion)
    {
        NombrePersona = nombrePersona;
        Precio = precio;
        DuracionSesiones = duracionSesiones;
        EdadMinima = edadMinima;
        Inscripcion = inscripcion;
    }

    public virtual double CalcularPrecioTotal(int edad)
    {
        double costoTotal = Precio;

        if (edad <= 8)
        {
            costoTotal += Inscripcion / 2;
        }
        else
        {
            costoTotal += Inscripcion;
        }

        return costoTotal;
    }

    public virtual string ObtenerRequisitos()
    {
        return $"Edad mínima requerida: {EdadMinima} años";
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre de la persona: {NombrePersona}");
        Console.WriteLine($"Precio: ${CalcularPrecioTotal(EdadMinima)}");
        Console.WriteLine($"Duración: {DuracionSesiones} semanas");
    }
}