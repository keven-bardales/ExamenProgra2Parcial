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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nNombre del maestro: {nombreMaestro}");
            sb.AppendLine("Materias que imparte:");
            foreach (Materia materia in listaClases)
            {

                sb.AppendLine($"- Fase: {materia.faseClase}\tSemana: {materia.semanaClase} \tTipo de Clase: {materia.tipoClase()} \tDuracion: {materia.Duracion}");
               
            }
            sb.AppendLine($"Horas trabajadas: {totalHorasTrabajadas}");
            return sb.ToString();
        }

        public string listarAlumnosClase(Materia materia)
        {
            return materia.listarAlumnos();
        }





    }
}
