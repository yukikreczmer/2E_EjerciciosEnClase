using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Estudiante
    {
        /*La clase Estudiante:

        Tendrá un constructor estático que inicializará el atributo estático random.
        Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        El método privado CalcularPromedio retornará el promedio de las dos notas.
        El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        caso contrario la inicializará con el valor -1.
        El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        Nombre, apellido y legajo.
        Nota del primer y segundo parcial.
        Promedio.
        Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
        Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
        Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
        Mostrar los datos de todos los alumnos. */

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;        
        
        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }
        private decimal CalcularPromedio()
        {
            decimal promedio;
            promedio = (decimal)(notaSegundoParcial + notaPrimerParcial)/2;
            return promedio;
        }

        public int CalcularNotaFinal()
        {
            if(notaPrimerParcial < 4 || notaSegundoParcial < 4)
            {
                return -1;
            }
            return random.Next(6, 10);            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota de Primer Parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota de Segundo Parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if(CalcularNotaFinal() == -1)
            {
                sb.AppendLine($"Alumno desaprobado");
            }
            else
            {
                sb.AppendLine($"Nota Final: {CalcularNotaFinal()}");
            }
            return sb.ToString();
        }
    }
}
