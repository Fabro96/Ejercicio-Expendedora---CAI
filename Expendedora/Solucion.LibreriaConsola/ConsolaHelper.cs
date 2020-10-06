using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaConsola
{
    public static class ConsolaHelper
    {
        public static int ValidarNumero(string mensaje)
        {
            int res;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("Ingrese un número válido por favor");
                    res = -1;
                }
            } while (res != 0 && res != 1);
            return res;
        }

        public static int ValidarOpcion(int min, int max, string mensaje)
        {
            int res;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("Ingrese un número válido por favor.");
                    res = -1;
                }
            } while (res < min || res > max);

            return res;
        }
        public static void ListarLatas()
        {
            Console.WriteLine("LATAS DISPONIBLES\n");
            Console.WriteLine("CO1 - Coca Cola Regular\n" +
                              "CO2 - Coca Cola Zero\n" +
                              "SP1 - Sprite Regular\n" +
                              "SP2 - Sprite Zero\n" +
                              "FA1 - Fanta Regular\n" +
                              "FA2 - Fanta Zero");
            Console.ReadKey();
        }
        public static void ListarCodigos()
        {
            Console.WriteLine("CÓDIGOS\n");
            Console.WriteLine("CO1\n" +
                              "CO2\n" +
                              "SP1\n" +
                              "SP2\n" +
                              "FA1\n" +
                              "FA2");
            
        }
        public static string PedirString(string msj)
        {
            Console.WriteLine("\nIngrese " + msj);
            string s = Console.ReadLine();
            return s;
        }
        public static double PedirDouble(string msj, int min, int max, string aviso)
        {
            double res;
            Console.WriteLine("\nIngrese " + msj);
            do
            {
                if (!double.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine(aviso);
                    res = -1;
                }
            } while (res < min || res > max);

            return res;
        }


    }
}
