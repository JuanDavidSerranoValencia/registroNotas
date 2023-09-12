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
        private List<double> parciales;
        private List<double> quices;
        private List<double>  trabajos;
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
            this.parciales = new List<double>();
            this.quices = new List<double>();
            this.trabajos = new List<double>();
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

        public List<double> Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }
        public List<double> Quices
        {
            get { return quices; }
            set { quices = value; }
        }
        public List<double> Trabajos
        {
            get { return trabajos; }
            set { trabajos = value; }
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
                            Console.WriteLine("{0,10} {1,10} {2,10} {3,10} {4,10}", "codigo", "nom", "correo", "edad", "direccion");
                        }
                        else
                        {
                            Console.Clear();
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
        public static void crearNotas(List<Estudiantes> lsEstudiante)
        {

            if (lsEstudiante.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados por favor registre algun estudiante");
            }
            else
            {   Estudiantes estudiantes= new Estudiantes();
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
                        Console.WriteLine("\nRegistro de parciales");
                        List<int> codigos = new List<int>();
                        for (int i = 0; i < lsEstudiante.Count; i++)
                        {
                            codigos.Add(lsEstudiante[i].cod);
                        }
                        if (opc == 1)
                        {
                            Console.Write("Ingrese el codigo del estudiante al que desea registrar Parciales:");
                            int cod = int.Parse(Console.ReadLine());
                            int index = codigos.IndexOf(cod);
                            if (index != -1)
                            {
                                for (int i = 0; i < lsEstudiante.Count; i++)
                                {
                                    if (lsEstudiante[i].cod == cod)
                                    {
                                        if (lsEstudiante[i].Parciales.Count != 0)
                                        {
                                            Console.WriteLine("El estudiante ya tiene sus notas registradas");
                                        }
                                        else
                                        {
                                            Console.Write("Ingrese el primer parcial:");
                                            double parcial1 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el segundo parcial:");
                                            double parcial2 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el tercer parcial:");
                                            double parcial3 = double.Parse(Console.ReadLine());

                                            if (parcial1 < 0 || parcial1 > 10 || parcial2 < 0 || parcial2 > 10 || parcial3 < 0 || parcial3 > 10)
                                            {
                                                Console.WriteLine("Las notas permitidas para los parciales son mayores a 0 y menores a 10");
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                lsEstudiante[i].Parciales.Add(parcial1);
                                                lsEstudiante[i].Parciales.Add(parcial2);
                                                lsEstudiante[i].Parciales.Add(parcial3);
                                                Console.WriteLine("Parciales registrados con exito");
                                            }

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
                            Console.Write("Ingrese el codigo del estudiante al que desea registrar quices:");
                            int cod = int.Parse(Console.ReadLine());
                            int index = codigos.IndexOf(cod);
                            if (index != -1)
                            {
                                for (int i = 0; i < lsEstudiante.Count; i++)
                                {
                                    if (lsEstudiante[i].cod == cod)
                                    {
                                        if (lsEstudiante[i].Quices.Count != 0)
                                        {
                                            Console.WriteLine("El estudiante ya tiene sus notas registradas");
                                        }
                                        else
                                        {
                                            Console.Write("Ingrese el primer quiz:");
                                            double quiz1 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el segundo quiz:");
                                            double quiz2 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el tercer quiz:");
                                            double quiz3 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el tercer quiz:");
                                            double quiz4 = double.Parse(Console.ReadLine());

                                            if (quiz1 < 0 || quiz1 > 10 || quiz2 < 0 || quiz2 > 10 || quiz3 < 0 || quiz3 > 10 || quiz4 < 0 || quiz4 > 10)
                                            {
                                                Console.WriteLine("Las notas permitidas para los parciales son mayores a 0 y menores a 10");
                                            }
                                            else
                                            {
                                                Console.Clear();
            
                                                lsEstudiante[i].Quices.Add(quiz1);
                                                lsEstudiante[i].Quices.Add(quiz2);
                                                lsEstudiante[i].Quices.Add(quiz3);
                                                lsEstudiante[i].Quices.Add(quiz4);
                                                Console.WriteLine("Quices registrados con exito");
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("El estudiante no se encuentra registrado");
                            }

                        }
                        else if (opc == 3)
                        {
                            Console.Write("Ingrese el codigo del estudiante al que desea registrar trabajos:");
                            int cod = int.Parse(Console.ReadLine());
                            int index = codigos.IndexOf(cod);
                            if (index != -1)
                            {
                                for (int i = 0; i < lsEstudiante.Count; i++)
                                {
                                    if (lsEstudiante[i].cod == cod)
                                    {
                                        if (lsEstudiante[i].Trabajos.Count != 0)
                                        {
                                            Console.WriteLine("El estudiante ya tiene sus notas registradas");
                                        }
                                        else
                                        {
                                            Console.Write("Ingrese el primer Trabajo");
                                            double trabajo1 = double.Parse(Console.ReadLine());
                                            Console.Write("Ingrese el segundo Trabajo:");
                                            double trabajo2 = double.Parse(Console.ReadLine());


                                            if (trabajo1 < 0 || trabajo1 > 10 || trabajo2 < 0 || trabajo2 > 10)
                                            {
                                                Console.WriteLine("Las notas permitidas para los parciales son mayores a 0 y menores a 10");
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                lsEstudiante[i].Trabajos.Add(trabajo1);
                                                lsEstudiante[i].Trabajos.Add(trabajo2);
                                                Console.WriteLine("Trabajos Agregados con exito");
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("El estudiante no se encuentra registrado");
                            }
                        }
                        else if (opc == 4)
                        {
                            Console.Clear();
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
                bool flag = true;
                while (flag)
                {

                    try
                    {

                        Console.WriteLine("Mostrar Estudiantes");
                        Console.WriteLine("1.Mostrar Todos los estudianes");
                        Console.WriteLine("2. Mostrar Paginas de a 10 estudiantes");
                        Console.WriteLine("3. Volver");
                        Console.WriteLine("Ingrese la opcion que desea realizar:");
                        int? opc = int.Parse(Console.ReadLine());
                        if (opc == 1)
                        {
                            Console.WriteLine("Lista de estudiantes");
                            for (int i = 0; i < lsEstudiantes.Count; i++)
                            {
                                Console.WriteLine(" Codigo: " + lsEstudiantes[i].cod + " Nombre: " + lsEstudiantes[i].nombre + " Nota Parcial: "+ " Nota Parcial: " + lsEstudiantes[i].parciales.Count);
                            }


                        }
                        else if (opc == 2)
                        {
                            Console.WriteLine("Paginado de estudiantes ");

                        }
                        else if (opc == 3)
                        {
                            Console.Clear();
                            flag = false;
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Ingrese una opcion valida a realizar");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encuentran estudiantes registrados");
            }

        }

    }
}