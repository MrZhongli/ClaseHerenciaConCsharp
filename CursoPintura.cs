public class CursoDibujoPintura : Curso
{
    public CursoDibujoPintura(string nombrePersona) : base(nombrePersona, 10, 5, 0, 5) { }

    public override string ObtenerRequisitos()
    {
        return "Puede ser tomado por todas las edades.";
    }
}