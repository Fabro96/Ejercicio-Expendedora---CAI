using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;


        public Expendedora()
        {
            this._latas = new List<Lata>();
        }

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }


        public void AgregarLata(Lata l)
        {

        }

        //ExtraerLata

        public string GetBalance()
        {
            return _dinero.ToString();
        }

        public int GetCapacidadRestante()
        {
            return _capacidad;
        }
        
        public void EncenderMaquina()
        {
            Console.WriteLine("Máquina Encendida!");
            Console.ReadKey();
        }
        
        //public bool EstaVacía()
        //{

        //}




    }
}
