using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Expendedora
    {
        //ATRIBUTOS
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        //CONSTRUCTOR
        public Expendedora()
        {
            this._latas = new List<Lata>();
        }

        //PROPIEDADES
        public List<Lata> Latas
        {
            get { return _latas; }
        }
        public string Proveedor
        {
            set { _proveedor = value; }
            get { return _proveedor;  }
        }
        public int Capacidad
        {
            get { return _capacidad; }
        }
        public double Dinero
        {
            set { _dinero = value; }
            get { return _dinero;  }
        }
        public bool Encendida
        {
            set { _encendida = value; }
            get { return _encendida;  }
        }

        //MÉTODOS
        public void AgregarLata(Lata lata)
        {

        }
        //public Lata ExtraerLata(string codigo, double dinero)
        //{

        //}
        //public string GetBalance()
        //{
            
        //}
        //public int GetCapacidadRestante()
        //{
           
        //}
        public void EncenderMaquina()
        {
            
            if (_encendida == true)
            {
                Console.WriteLine("Máquina Encendida!");
            }
            else
            {
                Console.WriteLine("La máquina no está encendida aún.");
            }
            Console.ReadKey();
        }
        //public bool EstaVacia()
        //{

        //}
    }
}
