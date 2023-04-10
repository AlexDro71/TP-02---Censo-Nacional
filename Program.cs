List<Persona> listaGente = new List<Persona>();
int op = ingresarInt("1. Cargar nueva persona\n2. Obtener estadisticas del censo\n3. Buscar persona\n4. Modificar mail de una persona\n5. Salir");
while (op != 5)
{
    switch (op)
    {
        case 1:
            listaGente.Add(cargarPersona());
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
    }
}

static int ingresarInt(string txt)
{
    int num;
    Console.WriteLine(txt);
    num = int.Parse(Console.ReadLine());
    return num;
}

static string ingresarString(string txt)
{
    string str;
    Console.WriteLine(txt);
    str = Console.ReadLine();
    return str;
}
static DateTime ingresarFecha(string tex1, string tex2, string tex3)
{
    int año = ingresarInt(tex1);
    int mes = ingresarInt(tex2);
    int dia = ingresarInt(tex3);
    DateTime fecha = new DateTime(año, mes, dia);
    return fecha;
}

static Persona cargarPersona()
{
    string mail, ape, nom;
    DateTime fecha;
    int DNI;
    DNI = ingresarInt("Ingrese su DNI: ");
    ape = ingresarString("Ingrese su apellido: ");
    nom = ingresarString("Ingrese su nombre: ");
    fecha = ingresarFecha("Ingrese su año de nacimineto:", "Ingrese su mes de nacimiento:", "Ingrese su dia de nacimiento: ");
    mail = ingresarString("Ingrese su email: ");

    Persona person = new Persona(DNI, ape, nom, fecha, mail);
    return person;
}


