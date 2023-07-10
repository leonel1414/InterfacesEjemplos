//Usos de Interfaces



var persona = new Persona();
persona.PreguntarNombre();
Console.WriteLine(persona.Nombre);
public class Persona : IPersona {

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }

    public void PreguntarNombre() {

        Console.WriteLine("Cual es tu Nombre?");
        var nombre = Console.ReadLine();
        if (nombre == null)
        {
            //
        }
        else { 
        Nombre = nombre;
        }
    }


}
public interface IPersona {

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }

    public void PreguntarNombre();
}