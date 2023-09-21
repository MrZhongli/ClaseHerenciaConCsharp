
/*CODIGO REALIZADO CON
KENNETH CHAN 
ALEJANDRO HERNANDEZ
SECCION C
*/

class Program
{
    static void Main(string[] args)
    {
        int edad = 10; // Cambiar para probar diferentes casos.
        //nombre, precio, año, edadMinima, y tipo de cocina 
        Curso curso1 = new CursoCocina("maria", 10, 5, 8, "Mediterránea");
        Curso curso2 = new CursoGuitarra("Carlos", true); // Carlos no tiene un instrumento
        Curso curso3 = new CursoDibujoPintura("Josefa");
        Curso curso4 = new CursoModelaje("Maria Alejandra crespo gutierrez", 'F', 13); // Maria puede tomar el curso de Modelaje


        Console.WriteLine($"\nDetalles del curso Cocina:\n");
        curso1.MostrarDetalles();
        Console.WriteLine(curso1.ObtenerRequisitos());
        Console.WriteLine($"Costo Total: ${curso1.CalcularPrecioTotal(edad)}");


        Console.WriteLine($"\nDetalles del curso Guitarra:\n");
        curso2.MostrarDetalles();
        Console.WriteLine(curso2.ObtenerRequisitos());
        Console.WriteLine($"Costo Total: ${curso2.CalcularPrecioTotal(edad)}");
    
        Console.WriteLine($"\nDetalles del curso Pintura:\n");
        curso3.MostrarDetalles();
        Console.WriteLine(curso3.ObtenerRequisitos());
        Console.WriteLine($"Costo Total: ${curso3.CalcularPrecioTotal(edad)}");

        
        Console.WriteLine($"\nDetalles del curso Modelaje:\n");
        curso4.MostrarDetalles();
        Console.WriteLine(curso4.ObtenerRequisitos());
        Console.WriteLine($"Costo Total: ${curso4.CalcularPrecioTotal(edad)}");
    }
}