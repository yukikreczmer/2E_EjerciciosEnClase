using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        /*Consigna
        Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

        Deberá tener los atributos:

        nombre
        fechaDeNacimiento
        dni
        Deberá tener un constructor que inicialice todos los atributos.

        Construir los siguientes métodos para la clase:

        Setter y getter para cada uno de los atributos.
        CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
        Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
        EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        Instanciar 3 objetos de tipo Persona en el método Main.
        Mostrar quiénes son mayores de edad y quiénes no.*/

        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento=fechaNacimiento;
        }
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void SetDni(int dni)
        {
            this.dni=dni;
        }
        public int GetDni()
        {
            return dni;
        }
        private int CalcularEdad()
        {                        
            int edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Fecha de Nacimiento: {GetFechaNacimiento().ToShortDateString()}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.Append($"DNI: {GetDni()}");
            return sb.ToString();            
        }
        public string EsMayorDeEdad()
        {
            if(CalcularEdad()>=18)
            {
                return "Es mayor de edad";
            }
            return "es menor";
        }

            /* EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        Instanciar 3 objetos de tipo Persona en el método Main.
        Mostrar quiénes son mayores de edad y quiénes no.*/
    }
}
