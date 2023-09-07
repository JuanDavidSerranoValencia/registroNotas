using System;
using System.Collections;
using System.Collections.Generic;
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

        public Estudiantes(){
        }


        public Estudiantes(int cod,String nombre,String correo,int edad,String direccion){

            this.cod=cod;
            this.nombre=nombre;
            this.correo=correo;
            this.edad= edad;
            this.direccion=direccion;
        }

        
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public int Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        

        public int Correo
        {
            get { return Correo; }
            set { Correo = value; }
        }
        
        public int Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }


        public int Direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        
       
        
        public static void  crearEstudiantes (List<Estudiantes> estudiantes,int cantidad){

            for (int i =0;i<cantidad-1;i++){
                Estudiantes estudiante= new Estudiantes();
                
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
}