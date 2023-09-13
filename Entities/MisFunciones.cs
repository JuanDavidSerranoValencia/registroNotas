using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registroNotas;

public class MisFunciones
{

    public static int menuPrincipal()
    {

        Console.WriteLine("\nRegistro Notas Estudiantes");
        Console.WriteLine("1 Registrar estudiantes");
        Console.WriteLine("2 Registrar Notas");
        Console.WriteLine("3 Mostrar Paginado ");
        Console.WriteLine("4 Salir");
        Console.Write("Ingrese la opcion que desea realizar:");
        return int.Parse(Console.ReadLine());
    }

    public static int menuEstudiantes()
    {
        Console.WriteLine("\nRegistro de notas");
        Console.WriteLine("1.Parciales");
        Console.WriteLine("2.Quices");
        Console.WriteLine("3.Trabajos");
        Console.WriteLine("4.Salir");
        Console.Write("Ingrese la opcion que desea realizar:");
        return int.Parse(Console.ReadLine());
    }

    public static int menuVerEstudiantes()
    {
        Console.WriteLine("\nMostrar Estudiantes");
        Console.WriteLine("1.Mostrar Todos los estudianes");
        Console.WriteLine("2. Mostrar Paginas de a 10 estudiantes");
        Console.WriteLine("3. Volver");
        Console.Write("Ingrese la opcion que desea realizar:");
        return int.Parse(Console.ReadLine());
    }

}
