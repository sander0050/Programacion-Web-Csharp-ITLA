using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string Nombre,int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public void GetDatosPersona()
        {
            Console.WriteLine("\nNombre: " + this.Nombre + " || Edad:" + this.Edad);
        }


    }
}
