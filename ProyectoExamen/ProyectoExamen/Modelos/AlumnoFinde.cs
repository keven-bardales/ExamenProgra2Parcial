using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class AlumnoFinde : Alumno
    {
        private double[] notas;

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }


        public override void calcPromedio()
        {

            double suma = 0;

            foreach (double i in notas)
            {
                suma += i;

            }

            base.promedio= suma / notas.Length;

        }
    }
}
