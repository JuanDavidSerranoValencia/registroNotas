using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registroNotas.Entities
{
    public class Notas
    {
        private int codEstudiante;
        private List<int>  ? parciales;
        private List<int>  ? quices;
        private List<int> ? trabajos;

        public Notas(){
        }
        public Notas(int codEstudiante,List<int> parciales,List<int>quices,List<int>trabajos){
            this.codEstudiante=codEstudiante;
            this.parciales= parciales;
            this.quices = quices;
            this.trabajos =trabajos;
        }

        public int  CodEstudiante
        {
            get { return codEstudiante; }
            set { codEstudiante = value; }
        }
        
       
        public List<int> Parciales
        {
            get { return parciales; }
            set { parciales = value; }
        }

       
        public List<int> Quices
        {
            get { return quices; }
            set { quices = value; }
        }
        
      
        public List<int> Trabajos
        {
            get { return trabajos; }
            set { trabajos = value; }
        }
        

    }

}