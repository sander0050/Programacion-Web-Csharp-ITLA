using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Web_CSharp
{
    class Cliente : Persona
    {
        public string Id_cliente { get; set; }

        public Cliente(string Nombre, int Edad, string Id_cliente) : base(Nombre, Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Id_cliente = Id_cliente;
        }

        public void GetInfoCliente()
        {
            Console.WriteLine("\nEmpleado\nNombre: " + this.Nombre + " || Edad: " + this.Edad + "|| Id_cliente: " + this.Id_cliente);
        }

    }
}
