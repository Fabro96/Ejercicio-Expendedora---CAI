using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            //INGRESO
            Console.WriteLine("BIENVENIDO A LA EXPENDEDORA!");
            Console.ReadKey();

            //MENÚ
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ DE USUARIO:");

                Console.WriteLine("\n   0 - ENCENDER" +
                                  "\n   1 - LATAS DISPONIBLES" +
                                  "\n   2 - INSERTAR BEBIDA" +
                                  "\n   3 - EXTRAER BEBIDA" +
                                  "\n   4 - BALANCE." +
                                  "\n   5 - STOCK");
                                
                Console.WriteLine("\nINGRESE LA OPCIÓN QUE DESEE VER:");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        break;
                    case 1:                        
                        break;
                    case 2:
                        //Método IngresarLata(Expendedora): void
                        break;
                    case 3:
                        //Método ExtraerLata(Expendedora): void
                        break;
                    case 4:
                        //Método ObtenerBalance(Expendedora): void
                        break;
                    case 5:
                        //MostrarStock();
                        
                        break;
                    default:
                        //Opción Inválida
                        break;
                }

            } while (opcion < 6);
            Console.ReadKey();

        }
        //IngresarLata
        public static void IngresarLata(Expendedora e)
        {
           
        }
        //ExtraerLata

        public static void ExtraerLata(Expendedora e)
        {

        }
        //ObtenerBalance
        public static void ObtenerBalance(Expendedora e)
        {

        }
        //MostrarStock
        public static void MostrarStock(Expendedora e)
        {
            
        }
        
    }
}
