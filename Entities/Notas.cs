using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace registroNotas.Entities
{
    public class Notas
    {
        private List<double> parciales;
        private List<double> quices;
        private List<double>  trabajos;

        public Notas (){

        }
        public Notas(List<double> parciales,List<double> quices,List<double> trabajos){
            this.parciales= parciales;
            this.quices= quices;
            this.trabajos = trabajos;

        }
        public List<double> Parciales { get => parciales; set => parciales = value; }
        public List<double> Quices { get => quices; set => quices = value; }
        public List<double> Trabajos { get => trabajos; set => trabajos = value; }
    }
}