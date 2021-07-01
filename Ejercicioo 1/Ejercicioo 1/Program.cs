using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];
            char buscar;
                char tiempo;
                int op = 0;


            Console.ReadKey();
            Console.Write("¿quiere ingresar, buscar o mostrar datos?: s/n ");
            tiempo = char.Parse(Console.ReadLine());
            while (tiempo == 's')
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Ingresar datos:");
                Console.WriteLine("2. Mostrar datos:");
                Console.WriteLine("3. Buscar datos:");
                Console.WriteLine("4. Salir:");
                op = int.Parse(Console.ReadLine());


                if (op == 1)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        Console.WriteLine("i: " + i);
                        Console.Write("Ingrese una letra: ");
                        dato[i] = char.Parse(Console.ReadLine());
                    }

                    Console.ReadKey();
                    Console.Clear();


                }
                else if (op == 2)
                {
                    for (int x = 0; x <= 9; x++)
                    {
                        Console.WriteLine(dato[x]);
                    }
                    tiempo = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.Write("Ingrese caracter a buscar: ");
                    buscar = char.Parse(Console.ReadLine());
                    for (int z = 0; z <= 9; z++)
                    {
                        if (dato[z] == buscar)
                        {
                            Console.Write("dato " + buscar + " encontrado");
                        }
                    }
                    tiempo = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (op == 4)
                  {
                    Environment.Exit(0);
                  }
            }   }
    }
}
