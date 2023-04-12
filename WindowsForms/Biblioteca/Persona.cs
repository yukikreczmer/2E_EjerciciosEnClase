namespace Biblioteca
{
    public class Persona
    {
        private string _nombre;
        private int _legajo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }

        Persona(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }
    }
}