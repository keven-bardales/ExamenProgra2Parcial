using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen.Modelos
{
    public class Maestro
    {
        public List<Materia> listaClases { get; set; } = new List<Materia>();
        public string nombreMaestro { get; set; }
        private const float SALARIO_POR_HORA = 120;
        private double salario;

        public int totalHorasTrabajadas { get; set; }

        public Cuenta cuentaMaestro { get; set; }

        public double getSalario() {
            return this.salario;
        }
        public void calcSalario()
        {
            this.salario = SALARIO_POR_HORA * totalHorasTrabajadas;
        }







    }
}
