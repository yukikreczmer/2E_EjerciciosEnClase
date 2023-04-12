using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static public  class Validadora
    {
        static public bool ValidarTexto(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        } 
        static public bool ValidarNumero(string input)
        {
            if(string.IsNullOrEmpty (input))
            {
                return false;                
            }
            for(int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }        
    }
}
