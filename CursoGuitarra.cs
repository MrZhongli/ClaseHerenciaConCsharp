public class CursoGuitarra : Curso
{
    public CursoGuitarra(string nombrePersona, bool tieneInstrumento) : base(nombrePersona, 20, 10, 0, 5)
    {
        TieneInstrumento = tieneInstrumento;
    }

    public bool TieneInstrumento { get; }

    public override double CalcularPrecioTotal(int edad)
    {
        double precioBase = base.CalcularPrecioTotal(edad);

        if (!TieneInstrumento)
        {
            return precioBase + 2;
        }

        return precioBase;
    }

    public override string ObtenerRequisitos()
    {
        string requisitos = "Puede ser tomado por todas las edades. ";

        if (!TieneInstrumento)
        {
            requisitos += "Requiere instrumento si no lo tienes.";
        }

        return requisitos;
    }
}
