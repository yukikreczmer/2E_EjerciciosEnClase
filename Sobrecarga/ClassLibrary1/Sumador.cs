namespace ClassLibrary1
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            _cantidadSumas = cantidadSumas;
        }
        public Sumador(): this(0)
        {            
        }

        public int CantidadSumas { get { return _cantidadSumas; } }

        public long Sumar(long a, long b)
        {
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            return a + b;
        }

        public static explicit operator int (Sumador sum1)
        {
            return sum1.CantidadSumas;
        }

        public static long operator + (Sumador sum1, Sumador sum2)
        {
            return sum1.CantidadSumas + sum2.CantidadSumas;
        }
        
        public static bool operator | (Sumador sum1, Sumador sum2)
        {
            return sum1._cantidadSumas == sum2._cantidadSumas;
        }
    }
}