using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    public class Empleado : Persona
    {
        public double Sueldo { get; set; }

        public Empleado(string Nombre, int Edad, double Sueldo) : base(Nombre, Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Sueldo = Sueldo;
        }

        public void GetInfoEmpleado()
        {
            Console.WriteLine("\nEmpleado\nNombre: " + this.Nombre + " || Edad: " + this.Edad + "|| Sueldo: " + this.Sueldo);
        }
    }
}
