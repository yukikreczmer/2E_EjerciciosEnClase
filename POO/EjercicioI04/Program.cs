using ClassLibrary1;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo b1 = new(ConsoleColor.Blue, 100);
            Boligrafo b2 = new(ConsoleColor.Red, 50);

            Console.WriteLine($"Tinta de boligrafo 1 {b1.GetColor()}: {b1.GetTinta()}");
            Console.WriteLine($"Tinta de boligrafo 2 {b2.GetColor()}: {b2.GetTinta()}");

            b1.Pintar(10, out dibujo);
            Console.WriteLine($"Se dibujo 10 con boligrafo {b1.GetColor()} 1.");
            Console.Write("Dibujo: ");
            Console.ForegroundColor=b1.GetColor();
            Console.WriteLine($"{dibujo}");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Tinta de boligrafo 1 {b1.GetColor()}: {b1.GetTinta()}");
            Console.WriteLine($"Tinta de boligrafo 2 {b2.GetColor()}: {b2.GetTinta()}");

            b2.Pintar(60, out dibujo);
            Console.WriteLine($"Se intentó dibujar 60 con boligrafo {b2.GetColor()} 2.");
            Console.Write("Dibujo: ");
            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine($"{dibujo}");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Tinta de boligrafo 1 {b1.GetColor()}: {b1.GetTinta()}");
            Console.WriteLine($"Tinta de boligrafo 2 {b2.GetColor()}: {b2.GetTinta()}");

            b1.Recargar();
            b2.Recargar();

            Console.WriteLine("Se recargaron los boligrafos.");
            Console.WriteLine($"Tinta de boligrafo 1: {b1.GetTinta()}");
            Console.WriteLine($"Tinta de boligrafo 2: {b2.GetTinta()}");

           
        }
    }
}