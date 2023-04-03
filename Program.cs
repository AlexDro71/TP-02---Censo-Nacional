int op = ingresarInt("1. Cargar nueva persona\n2. Obtener estadisticas del censo\n3. Buscar persona\n4. Modificar mail de una persona\n5. Salir");
while (op != 5)
{
    switch (op)
    {
        case 1:
            
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


