class Persona
{
    public int DNI { get; private set; }
    public string apellido { get; private set; }
    public string nombre { get; private set; }
    public DateTime fechaNacimiento { get; private set; }
    public string email { get; set; }

    public Persona(int DNI, string ape, string nom, DateTime fecha, string email)
    {

    }

    public int obtenerEdad(DateTime fecha)
    {
        int añoActual;
        int edad;
        DateTime actual = new DateTime();
       añoActual = actual.Year;
       edad = añoActual - fecha.Year;
       if(actual.Day < fecha.Day){
edad--;
       }
        
        return edad;
    }
    public bool puedeVotar(int edad)
    {
        if (edad >= 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}