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
        bool _encendida;

        public Expendedora()
        {
            this._latas = new List<Lata>();
            _capacidad = 60;
            
        }

        //public void AgregarLata(Lata lata)
        //{
            
        //}

        //public Lata ExtraerLata(string codigo, double dinero)
        //{

        //}

        //public string GetBalance()
        //{
        //    return 
        //}

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

        public bool EstaVacia()
        {
            if (_capacidad == 0)
            {
                Console.WriteLine("La Máquina está vacía.");
            }
            return true;
            
        }
        
        
    }
}
