using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string buscar;
            char tiempo;
            int op = 0;
            string[,] mat = new string[15, 5];
            int contacto= 0;


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
                    Console.WriteLine("Ingrese el numero de contactos que desea agregar: ");
                    contacto = Convert.ToInt32(Console.ReadLine());
                   for(int f=1; f<=contacto; f++)
                    {
                        for(int c= 0; c<5; c++)
                        {
                            Console.WriteLine("CONTACTO NO. "+f);
                            Console.Write("ingrese Nombre: ");
                            mat[f, c] = (Console.ReadLine());
                            c++;
                            Console.Write("ingrese Apellido: ");
                            mat[f, c] = Console.ReadLine();
                            c++;
                            Console.Write("ingrese Dirección: ");
                            mat[f, c] = (Console.ReadLine());
                            c++;
                            Console.Write("ingrese Telefono: ");
                            mat[f, c] = (Console.ReadLine());
                            c++;
                            Console.Write("ingrese Correo: ");
                            mat[f, c] = (Console.ReadLine());
                            Console.Write("\n");
                            Console.Clear();
                            
                        }
                    }

                }
 
                else if (op == 2)
                {
                    for (int f = 1; f <= contacto; f++)
                    {
                        for (int c = 0; c <5; c++)
                        {
                            Console.WriteLine("CONTACTO NO. " + f);
                            Console.WriteLine("NOMBRE: " + mat[f, c]);
                            c++;
                            Console.WriteLine("APELLIDO: " + mat[f, c]);
                            c++;
                            Console.WriteLine("DIRECCIÓN: " + mat[f, c]);
                            c++;
                            Console.WriteLine("TELEFONO: " + mat[f, c]);
                            c++;
                            Console.WriteLine("CORREO: " + mat[f, c]);
                           
                            Console.Write("\n");
                            
                        }

                        
                    }
                    
                }
                else if (op == 3)
                {
                    Console.Write("Ingrese el nombre a buscar: ");
                    buscar = (Console.ReadLine());
                    for (int f = 1; f <= contacto; f++)
                    { 
                        for(int c=0; c<5; c++)
                        {
                            if (mat[f,c] == buscar)
                            {
                                
                                Console.WriteLine("CONTACTO NO. " + f+ " Encontrado");
                                Console.WriteLine("NOMBRE: " + mat[f, c]);
                                c++;
                                Console.WriteLine("APELLIDO: " + mat[f, c]);
                                c++;
                                Console.WriteLine("DIRECCIÓN: " + mat[f, c]);
                                c++;
                                Console.WriteLine("TELEFONO: " + mat[f, c]);
                                c++;
                                Console.WriteLine("CORREO: " + mat[f, c]);
                                Console.Write("\n");
 
                            }

                        }
                        
                    }
                    
                }
                else if (op == 4)
                {
                    Environment.Exit(0);
                }

            }

        }

    }
}
