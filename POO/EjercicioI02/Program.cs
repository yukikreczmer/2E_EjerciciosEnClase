using ClassLibrary1;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
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

            Persona p1 = new("Roberto", new DateTime(1988, 10, 25),33456456);
            Persona p2 = new("Juana", new DateTime(2020, 01, 10),55000111);
            Persona p3 = new("Eustakio", new DateTime(1855, 10, 25),412312);

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p1.EsMayorDeEdad());
            Console.WriteLine("");
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p2.EsMayorDeEdad());
            Console.WriteLine("");
            Console.WriteLine(p3.Mostrar());
            Console.WriteLine(p3.EsMayorDeEdad());
            
            
        }
    }
}