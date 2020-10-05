using Solucion.LibreriaConsola;
using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicion.Consola
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

                opcion = ConsolaHelper.ValidarOpcion(0, 6, "\nINGRESE LA OPCIÓN QUE DESEE VER:");
                Console.Clear();

                try
                {
                    switch (opcion)
                    {
                        case 0:
                            //Encender Máquina
                            Exp.EncenderMaquina();
                            break;
                        case 1:
                            //Mostrar Listado de Latas
                            ConsolaHelper.ListarLatas();
                            break;
                        case 2:
                            //Método IngresarLata(Expendedora): void
                            Program.IngresarLata(Exp);
                            break;
                        case 3:
                            //Método ExtraerLata(Expendedora): void
                            Program.ExtraerLata(Exp);
                            break;
                        case 4:
                            //Método ObtenerBalance(Expendedora): void
                            Program.ObtenerBalance(Exp);
                            break;
                        case 5:
                            //MostrarStock(Exp);
                            Program.MostrarStock(Exp);
                            break;
                        case 6:
                            Exit();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nLo sentimos, hubo un error en el sistema. " + ex.Message);
                }

            } while (opcion <= 5) ;
        }
        //IngresarLata
        public static void IngresarLata(Expendedora Exp)
        {
            if (Exp.Encendida == true)
            {
                try
                {
                    //Se listan los códigos previamente establecidos
                    ConsolaHelper.ListarCodigos();
                    //Ingresar Código (tiene que ser válido)
                    string codigo = ConsolaHelper.PedirString("Código");
                    //Ingresar dinero
                    double dinero = ConsolaHelper.PedirDouble("Dinero");
                    //Ingresar volumen
                    double volumen = ConsolaHelper.PedirDouble("Volumen");
                    //Marca y sabor se ingresan automáticamente dependiendo del código que se ingresó
                    //Sumar lata al listado
                    Exp.AgregarLata(codigo);
                    Console.WriteLine("\nLata ingresada en la expendedora.");
                    Console.ReadKey();

                } catch (Exception ex)
                {
                    Console.WriteLine("Error en uno de los datos ingresados. " + ex.Message + " Intente nuevamente. \n\n");
                }
               
            }
            else
            {
                Console.WriteLine("La máquina no está encendida.\n\nVuelva al Menú Principal para encenderla.");
                
            }
            Console.ReadKey();
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
            if (Exp.Encendida == true)
            {
                foreach (Lata lata in Exp.Latas)
                {
                    Console.WriteLine(lata.ToString());
                }
            }
            else
            {
                Console.WriteLine("La máquina no está encendida. Vuelve al Manú Principal para encenderla.");
            }

            Console.ReadKey();
        }

        public static void Exit()
        {
            Console.WriteLine("MUCHAS GRACIAS POR HABER USADO LA EXPENDEDORA!\n\nIngrese una tecla y se apagará la máquina.");
            Console.ReadKey();
        }
        
    }
}
