using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear dos constructores:

            Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
            Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
            El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

            En el caso de Sumar(long, long) sumará los valores numéricos
            En el de Sumar(string, string) concatenará las cadenas de texto.
            Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

            Seguido:

            Generar una conversión explícita que retorne cantidadSumas.

            Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

            Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

            Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.*/

            long longA = 12;
            long longB = 6;

            string stringA = "pro";
            string stringB = "grama";
            
            long resultadoLong;
            string resultadoString;



            Sumador sumador1 = new Sumador(7);
            Sumador sumador2 = new Sumador(8);

            int cantidadSumasConvertido;
            long resultadoSobrecargaOperadorMas;

            resultadoLong = sumador1.Sumar(longA, longB);
            Console.WriteLine($"Resultado Suma de Long: {resultadoLong}");
           
            resultadoString= sumador1.Sumar(stringA, stringB);
            Console.WriteLine($"Resultado Concatenar strings: {resultadoString}");

            // SOBRECARGA DE OPERADORES
            Console.WriteLine();
            Console.WriteLine("Sobrecarga de operadores:");


            cantidadSumasConvertido = (int)sumador1;
            resultadoSobrecargaOperadorMas = sumador1 + sumador2;
            Console.WriteLine($"La suma de cantidadSumas de cada objeto Sumador con la sobrecarga del operador + es : {resultadoSobrecargaOperadorMas}");

            if(sumador1|sumador2)
            {
                Console.WriteLine($"Ambos sumadores tienen la misma cantidad de sumas: {(int)sumador1} y {(int)sumador2}");
            }
            else
            {
                Console.WriteLine($"Los sumadores tienen distinta cantidad de sumas: {(int)sumador1} y {(int)sumador2}");
            }

        }
    }
}