using System;

namespace Pilas_Dinamicas
{
    class program
    {
        public static int num;
        public static void Main(string[] args)
        {
            Stack Numeros = new Stack();
            string op = "";
            int va;

            do
            {
                Console.Clear();

                Console.WriteLine("******************** MENÚ DE OPCIONES - PILAS ESTATICAS ********************");
                Console.WriteLine("\n1. Insertar datos a la pila.");
                Console.WriteLine("2. Eliminar datos de la pila.");
                Console.WriteLine("3. Mostrar datos de las pilas.");

                Console.WriteLine("\nIngresa el valor a elegir:");
                Console.Write("-> ");
                va = Convert.ToInt32(Console.ReadLine());

                switch (va)
                {
                    case 1:
                        insertar(ref numeros);
                        break;
                    case 2:
                        eliminar();
                        break;
                    case 3:
                        mostrar();
                        break;
                    case 4:
                        //busqueda();
                        break;
                    case 5:
                        //impresion();
                        break;
                    case 6:
                        //mostrar();
                        break;
                    case 7:
                        //\\
                        break;
                    default:
                        Console.WriteLine("La opción a elegir no existe.");
                        break;
                }

                Console.WriteLine("¿Desea realizar alguna otra acción del menú? Si / No");
                Console.Write("-> ");
                op = Console.ReadLine();
            } while (op != "no");

            Console.WriteLine("Gracias por usar el programa, vuelva pronto.");
        }

        public static bool llena(ref Stack numeros)
        {
            if (numeros.Count < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void insertar()
        {
            int opc1 = 0;
            do
            {
                if (llena(ref numeros) == true)
                {
                    Console.WriteLine("Inserta un valor:");
                    Console.Write("-> ");
                    num = Convert.ToInt32(Console.ReadLine());
                    numeros.Push(num);
                    Console.WriteLine("Valor insertado con exito");

                    Console.WriteLine("¿Desea ingresar otro valor? 1.Si / 2.No");
                    Console.Write("-> ");
                    opc1 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Pila llena.");
                }
            } while (opc1 == 1);
        }
    }
}