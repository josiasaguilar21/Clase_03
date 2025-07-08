using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03.Clases
{
    public class Usuario
    {
        public int id;
        public string cedula;
        public string nombre;
        public string apellido;
        public string mail;
        private string tarjetaCredito;

        public Usuario(string cedula, string nombre, string apellido, string mail, string tarjetaCredito)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.tarjetaCredito = tarjetaCredito;
        }


        public string getTarjetaCredito1()
        {
            Console.WriteLine("Ingrese la cedula: ");
            string cedulaIngresada = Console.ReadLine();
            if (cedulaIngresada == this.cedula)
            {
                return tarjetaCredito;
            }
            else
            {
                Console.WriteLine("Cedula incorrecta, no tiene acceso a la tarjeta");
                return "Cedula incorrecta";
            }

        }

        public string getTarjetaCredito2()
        {
            int cantidadCaracteres = this.tarjetaCredito.Length;

            string retornoTarjetaCredito = this.tarjetaCredito.Replace(tarjetaCredito.Substring(0, cantidadCaracteres - 4), "**");

            return retornoTarjetaCredito;

        }

        public void setTarjetaCredito(string numeroTarjetaCredito)
        {
            Console.WriteLine("Ingrese la cedula: ");
            string cedulaIngresada = Console.ReadLine();
            if (cedulaIngresada == this.cedula)
            {
                this.tarjetaCredito = numeroTarjetaCredito;
            }
            else
            {
                Console.WriteLine("Cedula incorrecta, no tiene acceso a la tarjeta");
            }

        }
    }
}