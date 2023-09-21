public class CursoCocina : Curso
{
    public string TipoDeCocina { get; set; }

    public CursoCocina(string nombre, double precio, int duracionSesiones, int edadMinima, string tipoDeCocina)
        : base(nombre, precio, duracionSesiones, edadMinima, 5)
    {
        TipoDeCocina = tipoDeCocina;
    }

    public override double CalcularPrecioTotal(int edad)
    {
        
        double precioBase = base.CalcularPrecioTotal(edad);
        return DuracionSesiones * 2 + precioBase;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Tipo de Cocina: {TipoDeCocina}");
    }
}
