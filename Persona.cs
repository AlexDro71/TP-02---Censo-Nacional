class Persona
{
    public int DNI { get; private set; }
    public string apellido { get; private set; }
    public string nombre { get; private set; }
    public DateTime fechaNacimiento { get; private set; }
    public string email { get; set; }

    public Persona(int dni, string ape, string nom, DateTime fecha, string mail)
    {
        DNI = dni;
        apellido = ape;
        nombre = nom;
        fechaNacimiento = fecha;
        email = mail;
    }

    public int obtenerEdad()
    {

        int añoActual;
        int edad;
        DateTime actual = new DateTime();
        actual = DateTime.Today;
        añoActual = actual.Year;
        edad = añoActual - fechaNacimiento.Year;
        if (actual.Month < fechaNacimiento.Month || actual.Month == fechaNacimiento.Month && actual.Day < fechaNacimiento.Day)
        {
            edad--;
        }

        return edad;
    }
    public bool puedeVotar()
    {
        if (obtenerEdad() >= 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void mostrarDatos(){
        Console.WriteLine("DNI:"+DNI);
        Console.WriteLine("Apellido: "+apellido);
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Edad:"+obtenerEdad());
        Console.WriteLine("Fecha de nacimiento: "+fechaNacimiento.ToShortDateString());
        Console.WriteLine("Email: "+email);
        if(puedeVotar()){
            Console.WriteLine("Puede votar?: Si");
        }
        else{
            Console.WriteLine("Puede votar?: No");
        }
    }
}