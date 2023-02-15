using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class Alumno
    {

        private double[] notas;

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public string nombreAlumno { get; set; }

        private double promedio;

        public double getPromedio(double promedio)
        {
            return promedio;
        }

        public void calcPromedio(){

            double suma = 0;
            
            foreach(int i in notas)
            {
                suma += i;

            }

            promedio = suma / notas.Count();

        }



    }
}
