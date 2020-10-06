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
        public void AgregarLata(string codigo, double precio, double volumen)
        {
            Lata lata = new Lata(codigo, precio, volumen);

            switch (codigo.ToUpper())
            {
                case "CO1":
                    lata = new Lata(codigo, "Coca Cola", "Regular");
                    break;
                case "CO2":
                    lata = new Lata(codigo, "Coca Cola", "Zero");
                    break;
                case "SP1":
                    lata = new Lata(codigo, "Sprite", "Regular");
                    break;
                case "SP2":
                    lata = new Lata(codigo, "Sprite", "Zero");
                    break;
                case "FA1":
                    lata = new Lata(codigo, "Fanta", "Regular");
                    break;
                case "FA2":
                    lata = new Lata(codigo, "Coca Cola", "Zero");
                    break;
                default:
                    throw new Exception("Código inválido.");
            }
            this._latas.Add(lata);
            lata.Precio = precio;
            lata.Volumen = volumen;

            

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
            _encendida = true;
            Console.WriteLine("Máquina Encendida!");
            Console.ReadKey();
            
        }
        //public bool EstaVacia()
        //{

        //}
    }
}
