using ClassLibrary1;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

            titular que contendrá la razón social del titular de la cuenta.
            cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.
            mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/
            Cuenta cuenta1 = new("ramon", 15);
            Cuenta cuenta2 = new("rosalia", 20);

            Console.WriteLine("Situacion actual:");
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine("-----------------");
            Console.WriteLine(cuenta2.Mostrar());

            cuenta1.Ingresar(20);
            Console.WriteLine("-----------------");
            Console.WriteLine("Se ingresaron 20 en la cuenta de ramon");

            Console.WriteLine("Situacion actual:");
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine("-----------------");
            Console.WriteLine(cuenta2.Mostrar());

            cuenta2.Retirar(30);
            Console.WriteLine("-----------------");
            Console.WriteLine("Se retiraron 30 de la cuenta de rosalia");
            
            Console.WriteLine("Situacion actual:");
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine("-----------------");
            Console.WriteLine(cuenta2.Mostrar());

            cuenta1.Ingresar(-15);
            Console.WriteLine("-----------------");
            Console.WriteLine("Se intento ingresar -15 en la cuenta de ramon");
            
            Console.WriteLine("Situacion actual:");
            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine("-----------------");
            Console.WriteLine(cuenta2.Mostrar());

        }
    }
}