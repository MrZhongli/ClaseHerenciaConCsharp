public class CursoModelaje : Curso
{
    public char Genero { get; }
    public int Edad { get; }

    public CursoModelaje(string nombrePersona, char genero, int edad) : base(nombrePersona, 20, 5, 11, 5)
    {
        Genero = genero;
        Edad = edad;
    }

    public override string ObtenerRequisitos()
    {
        if (Genero == 'F' || Genero == 'f')
        {
            if (Edad > 11)
            {
                return "Puedes tomar el curso de Modelaje.";
            }
            else
            {
                return "Lo siento, este curso está disponible solo para niñas mayores de 11 años.";
            }
        }
        else
        {
            return "Lo siento, este curso está disponible solo para personas de género femenino.";
        }
    }
}
