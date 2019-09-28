using System;

namespace Programacion_Web_CSharp
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

            #region Tarea2
            /*1.	Retorne el valor máximo de un arreglo
              2.	Retorne la suma de todos sus valores
              3.	Retorne un arreglo con valores mayores a 18
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


            /*1.	Crear una matriz 4x4, llenar los valores de manera que si los índices son iguales se almacena un 1 y de lo contrario un 0.
              2.	Sumar los valores de cada diagonal.
              3.	Crear dos matrices 3x3 y crear otra con la suma de estas.
            */

            int[,] matriz4x4 = new int[4, 4];

            int suma = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x == y)
                    {
                        matriz4x4[x, y] = 1;
                        suma += matriz4x4[x, y];
                    }
                    else
                    {
                        matriz4x4[x, y] = 0;
                    }
                }
            }

            int[,] matriz3x3_1 = new int[3, 3] { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            int[,] matriz3x3_2 = new int[3, 3] { { -1, -1, -1 }, { -2, -2, -2 }, { -3, -3, -3 } }; ;

            int[,] matriz3x3_3 = new int[3, 3];

            for (int x = 0; x < matriz3x3_1.Length; x++) {
                for (int y = 0; y < matriz3x3_2.Length; y++) {
                    matriz3x3_3[x,y] = matriz3x3_1[x, y] + matriz3x3_2[x, y];
                }
            }

            #endregion

            #region Ejercicios_Clase_1
            /*1.	Realice 3 conceptos utilizando herencia*/
            Persona Person = new Persona("Roberto", 25);
            Empleado Empleado1 = new Empleado("Juan", 25, 20000);
            Cliente Cliente1 = new Cliente("Pedro", 23, "202");

            Person.GetDatosPersona();
            Empleado1.GetInfoEmpleado();
            Cliente1.GetInfoCliente();


            /*2.	Muestre los números pares del 1 al 100*/
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            /*3.	Averigua si un número es perfecto. 
             * Un número perfecto es un número natural que es igual a la suma 
             * de sus divisores propios positivos.*/

            Console.WriteLine(NumeroPerfecto(4));

            string NumeroPerfecto(int Number)
            {
                int sum = 0;

                for (int i = 1; i < Number; i++)
                {
                    if (Number % i == 0)
                    {
                        sum += i;
                    }

                }


                if (sum == Number)
                {
                    return "El numero " + Number + " es perfecto";
                }
                else
                {
                    return "El numero " + Number + "  no es perfecto";
                }
            }
        }

        /*4.	Basado en los conocimientos de programación orientada a objetos. Realizar:*/

        class Client
        {
            public string Nombre { get; set; }
            public double Monto { get; set; }

            public Client(string Nombre, double Monto)
            {
                this.Nombre = Nombre;
                this.Monto = Monto;
            }

            public void Depositar(double Deposito)
            {
                this.Monto += Deposito;
            }

            public void Extraer(double Cantidad)
            {
                this.Monto -= Cantidad;
            }

            public double RetornarMonto()
            {
                return this.Monto;
            }

        }

        class Banco
        {
            public Client cliente1 { get; set; }
            public Client cliente2 { get; set; }
            public Client cliente3 { get; set; }

            public Banco(Client cliente1, Client cliente2, Client cliente3)
            {
                this.cliente1 = cliente1;
                this.cliente2 = cliente2;
                this.cliente3 = cliente3;
            }

            public void Operar()
            {

            }

            public double DepositosTotales()
            {
                return cliente1.Monto + cliente2.Monto + cliente3.Monto;

            }


        }

        public abstract class FiguraGeometrica
        {
            public double Altura { get; set; }
            public double Ancho { get; set; }

            public FiguraGeometrica(double Altura, double Ancho)
            {
                this.Altura = Altura;
                this.Ancho = Ancho;
            }

            public abstract double GetArea();
        }

        public class Triangulo : FiguraGeometrica
        {

            Triangulo(double Altura, double Ancho) : base(Altura, Ancho)
            {
                this.Altura = Altura;
                this.Ancho = Ancho;
            }
            public override double GetArea()
            {
                return (this.Altura * this.Ancho) / 2;

            }

        }

        public class Cuadrado : FiguraGeometrica
        {

            Cuadrado(double Altura, double Ancho) : base(Altura, Ancho)
            {
                this.Altura = Altura;
                this.Ancho = Ancho;
            }
            public override double GetArea()
            {
                return this.Altura * this.Ancho;

            }

        }

        public class Circulo : FiguraGeometrica
        {
            public double Radio { get; set; }

            Circulo(double Altura, double Ancho, double Radio) : base(Altura, Ancho)
            {
                this.Altura = Altura;
                this.Ancho = Ancho;
                this.Radio = Radio;
            }
            public override double GetArea()
            {
                return Math.PI * (this.Radio * this.Radio);

            }

        }

        #endregion

        #region Tarea_2



        #endregion

    }





}



