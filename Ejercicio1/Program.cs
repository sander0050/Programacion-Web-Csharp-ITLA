using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Cuenta cuenta = new Cuenta("Juan");
            Console.WriteLine("\nCuenta: " + cuenta.Titular + " || Cantidad: " + cuenta.Cantidad);

            Cuenta cuenta2 = new Cuenta("Roberto", 100);
            Console.WriteLine("\nCuenta: " + cuenta2.Titular + " || Cantidad: " + cuenta2.Cantidad);
            

            Persona person = new Persona("Juan", 23);
            person.GetDatosPersona();

            Empleado empl1 = new Empleado("Rodrigo", 25, 20000);
            empl1.GetInfoEmpleado();
            */

            Arreglo arr = new Arreglo();

            int[] array = new int[10] { 3, 4, 2, 12, 5, 4, 32, 1, 7, 54 };
            string valores = "";

            Console.WriteLine("Valor Maximo: " + arr.ValorMaximo(array));
            Console.WriteLine("Suma de Valores: " + arr.SumaValores(array));

            array = arr.ValoresMayoresA18(array);

            for (int i = 0; i < array.Length; i++)
            {
                valores += array[i].ToString() + " ";
            }

            Console.WriteLine("Valores Mayores a 18: " + valores);

        }
    }
}
