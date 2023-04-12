using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string pais;

        public string[] Cursos { get => _cursos; set => _cursos = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Pais { get => pais; set => pais = value; }

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            Cursos = cursos;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
            Nombre = nombre;
            Pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Cursos: {Cursos}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Genero: {Genero}");
            sb.AppendLine($"Direccion: {Direccion}");
            sb.AppendLine($"Pais: {Pais}");
            return sb.ToString();
        }

    }
}
