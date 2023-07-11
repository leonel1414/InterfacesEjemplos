//Usos de Interfaces

var persona = new Persona();
//persona.PreguntarNombre();
//Console.WriteLine(persona.Nombre);
public class Persona : IPersona {

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }


    public Persona() {
        PreguntarDatos();
        EscribirDatos();
    }

    public void PreguntarDatos() {

        Console.WriteLine("Cual es tu Nombre?");
        var nombre = Console.ReadLine();
        if (nombre == null)
        {
            // mensaje que no introdujo el nombre
        }
        else { 
        Nombre = nombre;
        }

        Console.WriteLine("Cual es tu Fecha de nacimiento (aaaa/mm/dd)?");
        var fecha = Console.ReadLine();
        FechaNacimiento = DateOnly.Parse(fecha);
    }

    public void EscribirDatos() {
    
    Console.WriteLine($"Nombre:{Nombre}, Fecha de Nacimiento:{FechaNacimiento}");
    }

}
public interface IPersona {

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }

    public void PreguntarDatos();
    public void EscribirDatos() { }
}