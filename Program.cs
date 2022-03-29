using System;
using System.Collections.Generic;

namespace Pilas_Dinamicas
{
    class Program
    {
        public static Stack<string> ciudad = new Stack<string>();
        public static string c;

        static void Main(string[] args)
        {
            string opcV = "";
            do
            {
                int opc = 0;

                Console.WriteLine("Menú de opciones.");
                Console.WriteLine("1. Insertar valores");
                Console.WriteLine("2. Eliminación");
                Console.WriteLine("3. Búsqueda");
                Console.WriteLine("4. Imprimir los datos de la pila");
                Console.WriteLine("5. Mostrar información");
                Console.WriteLine("6. Salir");

                Console.Write("Ingrese una opción: ");
                Console.Write("-> ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        insertarValor();
                        break;
                    case 2:
                        eliminarValor();
                        break;
                    case 3:
                        buscarValor();
                        break;
                    case 4:
                        imprimirValor();
                        break;
                    case 5:
                        mostrarValores();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opción ingresada no existe, por favor inicie de nuevo");
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine("¿Desea realizar otra acición en el menu?");
                Console.Write("-> ");
                opcV = Console.ReadLine();
            } while (opcV == "si");
        }

        static bool verificaLleno()
        {
            if (ciudad.Count < 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool verificaVacia()
        {
            if (ciudad.Count < 0)
            {
                return true;
            }
            else return false;
        }

        static void insertarValor()
        {
            Console.Clear();
            do
            {
                Console.Write("Ingrese una ciudad o país al que le gustaría viajar: ");
                Console.Write("-> ");
                string valor = Console.ReadLine();
                if (ciudad.Count < 7)
                {
                    ciudad.Push(valor);
                }
                else
                {
                    Console.WriteLine("No hay más espacio en la pila");
                }
                Console.Write("¿Desea ingresar otro valor? Si / No");
                Console.Write("-> ");
                c = Console.ReadLine();
            } while (c != "no");
            Console.Clear();
        }
        static void eliminarValor()
        {
            Console.Clear();
            do
            {
                if (ciudad.Count >= 0)
                {
                    Console.WriteLine("Ciudad eliminado " + ciudad.Pop());
                }
                else
                {
                    Console.WriteLine("La pila ya esta vacia.");
                }
                Console.Write("¿Desea eliminar otro dato? Si / No ");
                Console.Write("-> ");
                c = Console.ReadLine();
            } while (c != "no");
            Console.Clear();
        }
        static void buscarValor()
        {
            Console.Clear();
            string cV;
            Console.Write("Ingrese el dato que desea buscar en la pila: ");
            Console.Write("-> ");
            cV = Console.ReadLine();
            if (ciudad.Contains(cV) == true)
            {
                Console.WriteLine("La ciudad ingresada si existe, " + cV);
            }
            else Console.WriteLine("No existe la ciudad en la pila");
            
        }
        static void imprimirValor()
        {
            Console.Clear();
            foreach (string ciu in ciudad)
            {
                Console.WriteLine(ciu);
            }
            Console.WriteLine("Presione la tecla <Enter> para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        static void mostrarValores()
        {
            Console.Clear();
            Console.WriteLine("Numero de datos actuales en la pila: " + ciudad.Count);
            Console.WriteLine("Ultimo valor insertado: " + ciudad.Peek());
            Console.WriteLine("Presione la tecla <Enter> para continuar");
            Console.ReadKey();
            Console.Clear();
        }

    }
} 