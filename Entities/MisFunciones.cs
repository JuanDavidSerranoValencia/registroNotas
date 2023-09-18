using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using registroNotas.Entities;
using Newtonsoft.Json;


namespace registroNotas;

public class MisFunciones
{

    public static int menuPrincipal()
    {

        Console.WriteLine("\nRegistro Notas Estudiantes");
        Console.WriteLine("1 Registrar estudiantes");
        Console.WriteLine("2 Registrar Notas");
        Console.WriteLine("3 Mostrar Paginado ");
        Console.WriteLine("4 Eliminar Estudiante");
        Console.WriteLine("5 Actualizar");
        Console.WriteLine("6 Salir");
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
        Console.WriteLine("2.Mostrar Paginas de a 10 estudiantes");
        Console.WriteLine("3. Volver");
        Console.Write("Ingrese la opcion que desea realizar:");
        return int.Parse(Console.ReadLine());
    }

    public static int menuActualizar()
    {
        Console.WriteLine("\n1.Actualizar Informacion Estudiante");
        Console.WriteLine("2.Actualizar Notas Estudiante");
        Console.WriteLine("3. Volver");
        Console.Write("Ingrese la opcion a realizar :");
        return int.Parse(Console.ReadLine());
    }

     public static void SaveData( List<Estudiantes> lstListado)
        {   
        string json = JsonConvert.SerializeObject(lstListado, Formatting.Indented);
        File.WriteAllText("boletin.json", json);
        }

        public static List<Estudiantes> LoadData()
        {
            string filePath = "boletin.json";

            if (!File.Exists(filePath))
            {
                try
                    {
                        File.WriteAllText(filePath, "[]");
                    }
                catch (Exception ex)
                    {
                        Console.WriteLine($"Error creating and initializing the file: {ex.Message}");
                    }
            }
            using (StreamReader reader = new StreamReader("boletin.json"))
            {
                string json = reader.ReadToEnd();
                return System.Text.Json.JsonSerializer.Deserialize<List<Estudiantes>>(json, new System.Text.Json.JsonSerializerOptions()
                { PropertyNameCaseInsensitive = true }) ?? new List<Estudiantes>();
            }
        }


}
