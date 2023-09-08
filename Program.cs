
using System.Collections;
using System.Runtime.InteropServices;
using registroNotas.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudiantes estudiante = new Estudiantes();
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nRegistro Notas Estudiantes");
            Console.WriteLine("1 Registrar estudiantes");
            Console.WriteLine("2 Registrar Notas");
            Console.WriteLine("3 Mostrar Paginado ");
            Console.WriteLine("4 Salir");
            try{
                int opc;
                Console.Write("Ingrese la opcion que desea realizar:");
                opc = int.Parse(Console.ReadLine());
                if(opc ==1){
                    Console.Clear();
                    Console.WriteLine("REGISTRO ESTUDIANTES");
                    List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
                    Estudiantes.crearEstudiantes(listaEstudiantes);
                    Console.WriteLine(listaEstudiantes);
                    
                
                    
                }else if (opc ==2){
                    Console.Clear();
                    Console.WriteLine("REGISTRO NOTAS");
                }else if(opc==3){
                    Console.Clear();
                    Console.WriteLine("MOSTRAR PAGINADO");
                }else if (opc ==4){
                    Console.Clear();
                    Console.WriteLine("SALIENDO DEL PROGRAMA..");
                    flag= false;
                }else{
                    Console.Clear();
                    Console.WriteLine("Ingrese Una opcion valida");
                }

            }
            catch (Exception e){  
                Console.Clear();
                Console.WriteLine("Ingrese valores numericos para poder seleccionar su opcion", e);

            }

        }
    }
}






 

// el profesor del area de matematicas necesita realizar un programa que permita registar los estudiante s
    //que se encuentran matriculados , la informacion que el docente tiene de cada estudiante es la siguiente
    //cod Long Max 15 caracteres , nombre del estudiante con una lon max de 40 caracteres, correo con una long max 40 caracteres
    // edad y direccion con una longitud de 35 caracteres no se conoce la cantidad de estudiantes que se registraon en la asignatura
    //la universidad tiene como norma que cada estudiente debe presnetar 4 quices , dos trabajos y 3 parciales
    //las notas de los quices equivalen al 25 % los trabajos al 15% y los parciales al 60
    //el programa debe permitirle al profesor generar los siguientes reportes
    //1 listado general de notas
    //2 paginado por 10 estudiantes
    //el porgrama debe permitirle al docente realizar todo el proceso de registro de notas por quices trabajos  y parciales 
    //se debe buscar el estudiante para poder registrar las notas