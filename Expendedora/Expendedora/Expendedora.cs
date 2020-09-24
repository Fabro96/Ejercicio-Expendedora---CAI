using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Expendedora
    {
        List<Lata> _latas;
        string _proveedor;
        int _capacidad;
        double _dinero;
        bool _encendido;

        public Expendedora()
        {

        }

        //AgregarLata(Lata) : void

        //ExtraerLata(string, double): Lata

        //GetBalance() : string

        //GetCapacidadRestante(): int

        //EncenderMaquina
        public void EncenderMaquina()
        {
            
            int ON = Validaciones.ValidarNumero("Hola! Para encender la máquina ingrese 0, " +
                "si desea volver al menú principal ingrese 1");

            
            if (ON == 0)
            {
                Console.WriteLine("\nMÁQUINA ENCENDIDA!");
                Console.ReadKey();
            }
            else if (ON == 1)
            {
                
            }

        }

        //EstaVacia(): bool 
        
        
    }
}
