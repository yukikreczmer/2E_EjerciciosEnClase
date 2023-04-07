using ClassLibrary1;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new("Gomez", "0001", "German");
            Estudiante e2 = new("Alvarez", "0002", "Julian");
            Estudiante e3 = new("Messi", "0003", "Lionel");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(4);
            
            e2.SetNotaPrimerParcial(3);
            e2.SetNotaSegundoParcial(8);

            e3.SetNotaPrimerParcial(9);
            e3.SetNotaSegundoParcial(10);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
            

        }
    }
}