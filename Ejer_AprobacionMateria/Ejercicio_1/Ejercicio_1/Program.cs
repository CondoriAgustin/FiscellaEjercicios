using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumplan lo anterior.

Tendrá dos métodos especiales:
ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.*/

namespace Ejercicio_1
{
    class Cuenta
    {
        public string titular;
        public double cantidad = 0;

        public Cuenta() { }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string Titular()
        {
            return "Titular: " + titular;
        }

        public double Retirar(double nuevaCantidad)
        {
            this.cantidad = this.cantidad - nuevaCantidad;
            if (this.cantidad > 0)
            {
                return this.cantidad;
            }
            else
            {
                return this.cantidad = 0;
            }
        }

        public double MontoTotal(double monto)
        {
            this.cantidad = this.cantidad + monto;
            if (this.cantidad > 0)
            {
                return this.cantidad;
            }
            else
            {
                return this.cantidad = 0;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            Console.WriteLine("Ingresar el nombre del titular: ");
            cuenta.titular = Console.ReadLine();


            while (true)
            {
                Console.Clear();
                Console.WriteLine(cuenta.Titular());
                Console.WriteLine("1. Ver saldo de la cuenta");
                Console.WriteLine("2. Ingresar Saldo de la cuenta");
                Console.WriteLine("3. Retirar Saldo de la cuenta");
                ConsoleKeyInfo tecla;
                double nuevaCantidad;
                double monto;

                tecla = Console.ReadKey();


                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("El saldo de la cuenta es: " + cuenta.cantidad);


                }

                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.Write("Ingresar cantidad a la cuenta: ");
                    monto = Convert.ToDouble(Console.ReadLine());

                    if (monto > 0)
                    {
                        cuenta.MontoTotal(monto);
                    }

                }

                if (tecla.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.Write("Retirar cantidad de la cuenta: ");
                    nuevaCantidad = Convert.ToDouble(Console.ReadLine());

                    if (nuevaCantidad > 0)
                    {
                        cuenta.Retirar(nuevaCantidad);
                    }

                }

                Console.ReadKey();
            }
        }


    }
}

