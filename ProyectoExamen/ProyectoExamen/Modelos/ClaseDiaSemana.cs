using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class ClaseDiaSemana : Materia, IClase
    {


        public void calcHorasClase()
        {
            base.Duracion = 1;
        }
        public override string tipoClase()
        {
            return $"Clase Dias de Semana";
        }
    }
}
