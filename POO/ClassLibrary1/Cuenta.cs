using System.Text;

namespace ClassLibrary1
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
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
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }
        public decimal GetCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string titular;
            decimal cantidad;

            titular = GetTitular();
            cantidad = GetCantidad();
            
            sb.AppendLine($"Titular de la cuenta: {titular}");            
            sb.Append($"Monto de la cuenta: {cantidad}");
            return sb.ToString();
        }
        public void Ingresar(decimal montoAIngresar)
        {
            if(montoAIngresar>0)
            {
                this.cantidad+=montoAIngresar;
            }
        }
        public void Retirar(decimal montoARetirar)
        {
            this.cantidad-=montoARetirar;
        }
        
        

    }
}