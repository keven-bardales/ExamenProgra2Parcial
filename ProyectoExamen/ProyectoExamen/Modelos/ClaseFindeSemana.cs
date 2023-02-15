using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class ClaseFindeSemana : Materia, IClase
    {

        //Utilizamos la interfaz IClase que tiene el metodo calcHorasClase
       void IClase.calcHorasClase() {
            base.Duracion = 4;
        }


        public override string tipoClase()
        {
            return $"Clase Fin de Semana";
        }


    }
}
