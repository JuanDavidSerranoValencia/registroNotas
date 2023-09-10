using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace registroNotas.Entities
{
    public class Estudiantes
    {
        private int cod;
        private String nombre;
        private String correo;
        private int edad;
        private String direccion;
        private int parciales;
        private int quices;
        private int trabajos;
        public Estudiantes()
        {
        }
        public Estudiantes(int cod, String nombre, String correo, int edad, String direccion)
        {
            this.cod = cod;
            this.nombre = nombre;
            this.correo = correo;
            this.edad = edad;
            this.direccion = direccion;
            this.parciales = 0;
            this.quices = 0;
            this.trabajos = 0;
        }

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }

        public static void crearEstudiantes(List<Estudiantes> lsEstudiantes, Estudiantes estudiante)
        {
            Console.Write("Ingrese la cantidad de estudiantes que desea registrar:");
            int cantidad = int.Parse(Console.ReadLine());
            int agregados = 0;
            while (agregados < cantidad)
            {
                try
                {
                    Console.Write("\nIngrese el Codigo del estudiante:");
                    String? cod = Console.ReadLine();
                    Console.Write("Ingrese el nombre del estudiante:");
                    String? nom = Console.ReadLine();
                    Console.Write($"Ingrese el correo del estudiante {nom}:");
                    String? correo = Console.ReadLine();
                    Console.Write($"Ingrese la edad del estudiante {nom}:");
                    String? edad = Console.ReadLine();
                    Console.Write($"Ingrese la direccion del estudiante {nom}:");
                    String? direccion = Console.ReadLine();
                    if (edad != null && edad != "" && nom != null && nom != "" && cod != null && cod != "" && correo != null && correo != "" && direccion != null && direccion != "")
                    {
                        if (cod.Length <= 0 || cod.Length > 16 || nom.Length <= 0 || nom.Length > 41 || correo.Length <= 0 || correo.Length > 36 || edad.Length <= 0 || edad.Length > 36 || direccion.Length <= 0 || direccion.Length > 36)
                        {
                            Console.WriteLine("Los datos no corresponden con las longitudes especificas");
                            Console.WriteLine("{0,10} {0,10} {0,10} {0,10} {0,10}", "codigo", "nom", "correo", "edad", "direccion");
                        }
                        else
                        {
                            estudiante = new Estudiantes(int.Parse(cod), nom, correo, int.Parse(edad), direccion);
                            lsEstudiantes.Add(estudiante);
                            agregados = agregados + 1;
                            Console.WriteLine("Estudiante creado con exito");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Verifique los datos ingresados correspondan con lo solicitado");

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Debe ingresar valores validos para los datos solicitados", e);
                }

            }

        }

        public static void crearNotas(List<Estudiantes> lsEstudiante, Estudiantes estudiante)
        {

            if (lsEstudiante.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados por favor registre algun estudiante");
            }
            else
            {
                bool flag = true;
                while (flag)
                {
                    try
                    {
                        Console.WriteLine("\nRegistro de notas");
                        Console.WriteLine("1.Parciales");
                        Console.WriteLine("2.Quices");
                        Console.WriteLine("3.Trabajos");
                        Console.WriteLine("4.Salir");
                        Console.Write("Ingrese la opcion que desea realizar:");
                        int? opc = int.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            Console.WriteLine("\nRegistro de parciales");
                            List<int> codigos = new List<int>();
                            for (int i = 0; i < lsEstudiante.Count; i++)
                            {
                                codigos.Add(lsEstudiante[i].cod);
                            }
                            Console.Write("Ingrese el codigo del estudiante al que desea registrar notas:");
                            int cod = int.Parse(Console.ReadLine());
                            int index = codigos.IndexOf(cod);
                            if (index != -1)
                            {
                                for (int i = 0; i < lsEstudiante.Count; i++)
                                {
                                    if (lsEstudiante[i].cod == cod)
                                    {
                                        if (lsEstudiante[i].Parciales != 0)
                                        {

                                            Console.WriteLine("El estudiante ya tiene sus notas registradas");
                                        }
                                        else
                                        {

                                            Console.Write("Ingrese el primer parcial:");
                                            int parcial1 = int.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el segundo parcial:");
                                            int parcial2 = int.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el tercer parcial:");
                                            int parcial3 = int.Parse(Console.ReadLine());

                                            lsEstudiante[i].Parciales = 25;

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
                                        }

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("El estudiante no se encuentra registrado");
                            }

                        }
                        else if (opc == 2)
                        {

                        }
                        else if (opc == 3)
                        {

                        }
                        else if (opc == 4)
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("la opcion ingresada no es valida");
                        }

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Debe ingresar datos correctamente ");
                    }
                }
            }

        }
        public static void mostrarEstudiantes(List<Estudiantes> lsEstudiantes)
        {
            if (lsEstudiantes.Count != 0)
            {
                for (int i = 0; i < lsEstudiantes.Count; i++)
                {
                    Console.WriteLine("Codigo:" + lsEstudiantes[i].cod);
                    Console.WriteLine("Codigo:" + lsEstudiantes[i].parciales);

                }
            }
            else
            {
                Console.WriteLine("No se encuentran estudiantes registrados");
            }

        }

    }
}