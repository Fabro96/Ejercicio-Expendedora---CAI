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
            Console.WriteLine("CO1\n" +
                              "CO2\n" +
                              "SP1\n" +
                              "SP2\n" +
                              "FA1\n" +
                              "FA2");
            Console.ReadKey();
        }
        public static string IngresarCodigo(string codigo)
        {
            Console.WriteLine("\nIngrese el CÓDIGO de la lata que desea ingresar: ");
            
            switch (codigo)
            {
                case "CO1":
                    break;
                //Continuar
            }
            return codigo;
        }

        
    }
}
