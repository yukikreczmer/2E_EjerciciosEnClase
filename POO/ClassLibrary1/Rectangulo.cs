using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto? vertice1;
        private Punto? vertice2;
        private Punto? vertice3;
        private Punto? vertice4;

        public Rectangulo(Punto? vertice1, Punto? vertice3)
        {            
            this.vertice1 = vertice1;
            //this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            //this.vertice4 = vertice4;
            Math.Abs()
        }

        public float Area()
        {

        }
        public float Perimetro()
        {

        }

        public float GetArea()
        {
            if(area is not null)
            {

            }
            return area;
        }
        public float GetPerimetro()
        {
            return perimetro;
        }

    }

}
