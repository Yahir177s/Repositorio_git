using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuopcion;
            Console.Clear();
            Cuadro(1, 80, 1, 6);
            Titulos();
            Menu();
            menuopcion = MenuChoice();
            DoChoice(menuopcion);

            Console.ReadKey();
        }
            
            public static void Cuadro(int x1, int x2, int y1, int y2)
            {
                for (int x=x1; x<=x2; x++)
                {
                    Console.SetCursorPosition(x, y1); Console.Write("=");
                    Console.SetCursorPosition(x, y2); Console.Write("=");
                }

                for (int y = y1; y <= y2; y++)
                {
                    Console.SetCursorPosition(x1, y); Console.Write("║");
                    Console.SetCursorPosition(x2, y); Console.Write("║");
                }

                Console.SetCursorPosition(x1, y1); Console.Write("╔");
                Console.SetCursorPosition(x2, y1); Console.Write("╗");
                Console.SetCursorPosition(x1, y2); Console.Write("╚");
                Console.SetCursorPosition(x2, y2); Console.Write("╝");
            }

            public static void Titulos()
            {
                string t1 = "Empresas Los Vendedores, S. A.",
                t2 = "El placer del buen servicio",
                t3 = "Sistema de inventario",
                t4 = "M E N U  P R I N C I P A L";

                Console.SetCursorPosition((80 - t1.Length) / 2, 2);
                Console.Write(t1);

                Console.SetCursorPosition((80 - t2.Length) / 2, 3);
                Console.Write(t2);

                Console.SetCursorPosition((80 - t3.Length) / 2, 4);
                Console.Write(t3);

                Console.SetCursorPosition((80 - t4.Length) / 2, 5);
                Console.Write(t4);
            }

            public static void Menu()
            {
                Console.SetCursorPosition(15, 8);
                Console.Write("1- Registrar Categoria de productos");

                Console.SetCursorPosition(15, 9);
                Console.Write("2- Registrar Productos");

                Console.SetCursorPosition(15, 10);
                Console.Write("3- Aumentar inventario");

                Console.SetCursorPosition(15, 11);
                Console.Write("4- Reducir inventario");

                Console.SetCursorPosition(15, 12);
                Console.Write("5- Consultar inventario");

                Console.SetCursorPosition(15, 13);
                Console.Write("0- Salir");
            }
            public static int MenuChoice()
            {
                int op = 1;

                do
                {
                    try
                    {
                        Console.SetCursorPosition(20, 15);
                        Console.Write("Su opcion...: ");
                        op = int.Parse(Console.ReadLine());
                        if (op < 0 || op > 5)
                        {
                            Console.SetCursorPosition(20, 24);
                            Console.WriteLine("Ha elegido una no válida");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.SetCursorPosition(20, 24);
                        Console.Write(e.Message);
                    }
                } while (op < 0 || op > 5);

                return op;
            }
            public static void DoChoice(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        Console.SetCursorPosition(20, 24);
                        Console.Write("En construccion");
                        break;
                    case 2:
                      
                        Console.SetCursorPosition(0,24);
                        Console.Write("En construccion");
                        break;
                    case 3:
                        Console.SetCursorPosition(20, 24);
                        Console.Write("En construccion");
                        break;
                    case 4:
                        Console.SetCursorPosition(20, 24);
                        Console.Write("En construccion");
                        break;
                    case 5:
                        
                        Console.SetCursorPosition(20,24);
                        Console.Write("En construccion");
                        break;
                }
            }
        
    }
}

