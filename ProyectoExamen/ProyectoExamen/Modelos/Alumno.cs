using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class Alumno
    {

       

        public string nombreAlumno { get; set; }

        public double promedio { get; set; }

        
        public virtual void calcPromedio()
        {
           
        }

        public override string ToString()
        {
            
            return $"\nNombre del alumno: {nombreAlumno}, Promedio: {promedio}";
        }



    }
}
