using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class Materia
    {
        public List<Alumno> listaAlumnos { get; set; } = new List<Alumno>();
        public int faseClase { get; set; }
        public int semanaClase { get; set; }
        public int Duracion { get; set; }

        public virtual string tipoClase()
        {
            return $"Esta es la clase Padre";
        }

        public Maestro maestroasignado { get; set; }

        public virtual string listarAlumnos() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nListado de Alumnos de Clase \nFase: {faseClase} \t Semana Clase: {semanaClase} Maestro: {maestroasignado.nombreMaestro}");
            foreach (Alumno alumno in listaAlumnos)
            {
                sb.AppendLine($"{alumno.ToString()}");
            }

            return  sb.ToString();
        }


    }
}
