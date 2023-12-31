﻿
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using registroNotas;
using registroNotas.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudiantes estudiante = new Estudiantes();
        List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
        bool flag = true;
        while (flag)
        {

            try
            {
                int? opc = MisFunciones.menuPrincipal();
                if (opc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("REGISTRO ESTUDIANTES");
                    Estudiantes.crearEstudiantes(listaEstudiantes, estudiante);
                    MisFunciones.SaveData(listaEstudiantes);

                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("REGISTRO NOTAS");
                    Estudiantes.crearNotas(listaEstudiantes);

                }
                else if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine("MOSTRAR PAGINADO");
                    Estudiantes.mostrarEstudiantes(listaEstudiantes);

                }
                else if (opc == 4)
                {
                    Console.Clear();
                    Console.WriteLine("ELIMINAR ESTUDIANTES");
                    Estudiantes.deleteEstudiante(listaEstudiantes);
                }
                else if (opc == 5)
                {
                    Console.Clear();
                    Console.WriteLine("ACTUALIZAR DATOS");
                    Estudiantes.updateEstudiante(listaEstudiantes);
                }
                else if (opc == 6)
                {
                    Console.Clear();
                    Console.WriteLine("SALIENDO DEL PROGRAMA..");
                    flag = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese Una opcion valida");
                }

            }
            catch (Exception e)
            {
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