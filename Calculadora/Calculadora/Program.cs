using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char tiempo;
            int op = 0;
            double n1 = 0, n2 = 0, s = 0, r = 0, m = 0, d = 0;

            Console.ReadKey();
            Console.Write("¿quiere realizar operaciones numericas?: s/n ");
            tiempo = char.Parse(Console.ReadLine());
            while (tiempo == 's')
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Suma:");
                Console.WriteLine("2. Resta:");
                Console.WriteLine("3. Multiplicación:");
                Console.WriteLine("4. División:");
                Console.WriteLine("5. Salir:");
                op = int.Parse(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine("ingrese primer numero: ");
                    try
                    {
                        n1 = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    }
                   
                    Console.WriteLine("ingrese segundo numero: ");
                    try
                    {
                        n2 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                    }
                    s = n1 + n2;
                    Console.WriteLine("la suma es de:"+ s);
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (op == 2)
                {
                    Console.WriteLine("ingrese primer numero: ");
                    try
                    {
                        n1 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    Console.WriteLine("ingrese segundo numero: ");
                    try
                    {
                        n2 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                    }
                    r = n1 - n2;
                    Console.WriteLine("la resta es de:" + r);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.WriteLine("ingrese primer numero: ");
                    try
                    {
                        n1 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("ingrese segundo numero: ");
                    try
                    {
                        n2 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                    } 
                    m = n1 * n2;
                    Console.WriteLine("la multiplicación es de:" + m);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 4)
                {
                    Console.WriteLine("ingrese primer numero: ");
                    try
                    {
                        n1 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("ingrese segundo numero: ");
                    try
                    {
                        n2 = Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Error, el dato no se procesará");
                        Console.WriteLine("ingrese primer numero: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                    }
                    d = n1 / n2;
                    Console.WriteLine("la división es de:" + d);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 5)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
    }

