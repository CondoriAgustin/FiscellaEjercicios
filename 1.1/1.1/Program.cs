using _1._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Persona
    {
        public string name;
        public int age;
        public int dni;

        public Persona()
        {
        }


        public Persona(string name, int age , int dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
        }
   
        public string mostrarTodo()
        {
            return name + ", " + age + ", "+ dni;
        }

    }

    internal class Program
    {
        static List<Persona> list = new List<Persona>();
        static Persona buscar(int dni)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dni == dni){
                    return list[i];
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Persona persona1;
            list.Add(new Persona("Sergio", 14 , 46881421));
            list.Add(new Persona("Pablo", 10 , 47236081));
            list.Add(new Persona("Florencia", 12 , 46464646));
            string nombre = persona.name;
            int dni;

            while (true)
            {

                ConsoleKeyInfo tecla;
                Console.Clear();
                Console.WriteLine("1. Ver todas las Personas");
                Console.WriteLine("2. Buscar persona por DNI");
                Console.WriteLine("3. Buscar persona por DNI para luego borrar");
                tecla = Console.ReadKey();



                if (tecla.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i].mostrarTodo());
                    }
                }

                if (tecla.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el DNI de la persona");
                    dni = Convert.ToInt32(Console.ReadLine());
                    if(buscar(dni) == null)
                    {
                        Console.Clear();
                        Console.WriteLine("La persona no se encontro. Trate colocando otro DNI");
                    }
                    else
                    {
                        Console.Clear();
                        persona1 = buscar(dni);
                        Console.WriteLine("El DNI se encontro y le pertenece a: " + persona1.name + " , " + persona1.age);
                    }

                }

                if(tecla.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.Write("Colocar el DNI de la persona para ser eliminado: ");
                    dni = Convert.ToInt32(Console.ReadLine());
                    persona1 = buscar(dni);

                    if (persona1 != null)
                    {
                        list.Remove(persona1);
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i].mostrarTodo());
                    }
                }
                Console.ReadKey();
            }
      

        }
    }
}

