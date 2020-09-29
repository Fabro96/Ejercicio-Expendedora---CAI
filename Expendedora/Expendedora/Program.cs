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
            Console.WriteLine("BIENVENIDO A LA EXPENDEDORA!\n\nIngrese cualquier teclara ir al MENÚ DEL USUARIO.");
            Console.ReadKey();

            Expendedora Exp = new Expendedora();

            List<Lata> listaLatas = new List<Lata>();

            Lata CO1 = new Lata("CO1", "Coca Cola", "Regular");
            listaLatas.Add(CO1);


            //MENÚ
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ DEL USUARIO:");

                Console.WriteLine("\n   0 - ENCENDER" +
                                  "\n   1 - LATAS DISPONIBLES" +
                                  "\n   2 - INSERTAR BEBIDA" +
                                  "\n   3 - EXTRAER BEBIDA" +
                                  "\n   4 - BALANCE" +
                                  "\n   5 - STOCK" +
                                  "\n   6 - EXIT");

                opcion = Validaciones.ValidarOpcion(0, 6, "\nINGRESE LA OPCIÓN QUE DESEE VER:");
                Console.Clear();
                
                switch (opcion)
                {
                    case 0:
                        //Encender Máquina
                        Exp.EncenderMaquina();
                        break;
                    case 1:
                        //Mostrar Listado de Latas
                        foreach (Lata lata in listaLatas)
                        {
                            Console.WriteLine(lata.ToString());
                            Console.ReadKey();
                        }
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
                        //MostrarStock(Exp);
                        
                        break;
                    case 6:
                        Exit();
                        break;
                }

            } while (opcion <= 5);
            

        }

        

        //IngresarLata
        public static void IngresarLata(Expendedora Exp)
        {
           
        }

        //ExtraerLata
        public static void ExtraerLata(Expendedora Exp)
        {

        }

        //ObtenerBalance
        public static void ObtenerBalance(Expendedora Exp)
        {

        }

        //MostrarStock
        public static void MostrarStock(Expendedora Exp)
        {
            Exp.EstaVacia();
        }

        public static void Exit()
        {
            Console.WriteLine("MUCHAS GRACIAS POR HABER USADO LA EXPENDEDORA!\n\nIngrese una tecla y se cerrará el sistema.");
            Console.ReadKey();
        }
        
    }
}
