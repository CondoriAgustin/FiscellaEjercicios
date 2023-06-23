using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_2
{

    class Persona
    {
        public string nombre;
        public double edad = 0;
        public double dni;
        public char sexo = 'H';
        public double peso = 0;
        public double altura = 0;

        public Persona() { }

        public Persona(string nombre, double edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;

        }

        public Persona(string nombre, double edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            this.dni = generarDNI();

        }

        public string mostrarTodo()
        {
            return nombre + ", " + edad;
        }

        public int generarDNI()
        {
            Random random = new Random();
            int randomNumero = random.Next(10000000, 99999999);
            return randomNumero;
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>();
            string nombre = "";
            double edad = 0;
            char sexo = 'H';
            double peso = 0;
            double altura = 0;

            Console.Write("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese la edad de la persona: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese el sexo de la persona: ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese el peso de la persona: ");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese la altura de la persona: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            persona.Add(new Persona(nombre, edad, sexo, peso, altura));
            persona.Add(new Persona(nombre, edad, sexo));
            persona.Add(new Persona());


            Console.ReadKey();
        }
    }
}