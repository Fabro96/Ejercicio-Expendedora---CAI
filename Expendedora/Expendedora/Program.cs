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

            Expendedora Exp1 = new Expendedora();

            List<Lata> listaLatas = new List<Lata>();

            Lata CO1 = new Lata("CO1", "Coca Cola", "Regular");
            listaLatas.Add(CO1);
            Lata CO2 = new Lata("CO2", "Coca Cola", "Zero");
            listaLatas.Add(CO2);
            Lata SP1 = new Lata("SP1", "Sprite", "Regular");
            listaLatas.Add(SP1);
            Lata SP2 = new Lata("SP2", "Sprite", "Zero");
            listaLatas.Add(SP2);
            Lata FA1 = new Lata("FA1", "Fanta", "Regular");
            listaLatas.Add(FA1);
            Lata FA2 = new Lata("FA2", "Fanta", "Zero");
            listaLatas.Add(FA2);


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
                        Exp1.EncenderMaquina();
                        break;
                    case 1:
                        foreach (Lata lata in listaLatas)
                        {
                            Console.WriteLine(lata.ToString());

                        }
                        Console.ReadKey();
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
