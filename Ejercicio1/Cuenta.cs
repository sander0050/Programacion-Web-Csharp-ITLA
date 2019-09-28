using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Web_CSharp
{
    public class Cuenta
    {
        public string Titular { get; set; }
        public double Cantidad { get; set; }
        
        public Cuenta(string Titular) {
            this.Titular = Titular;
        }

        public Cuenta(string Titular, double Cantidad)
        {
            this.Titular = Titular;
            this.Cantidad = Cantidad;
        }

        public void Ingresar(double Cantidad)
        {
            if (Cantidad >= 0) {
                this.Cantidad = Cantidad;
            }
        }

        public void Retirar(double Cantidad) {
            double retiro = this.Cantidad - Cantidad;

            if (retiro < 0)
            {
                this.Cantidad = 0;
            }
            else {
                this.Cantidad = retiro;
            }
        }
    }
}
