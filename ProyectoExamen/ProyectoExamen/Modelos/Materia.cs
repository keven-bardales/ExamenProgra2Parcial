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


    }
}
