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
            this._capacidad = 60;
            
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
            
            if (GetCapacidadRestante() == 0)
            {
                throw new CapacidadInsuficienteException("\nLa Expendedora no tiene capacidad suficiente para ingresar otra lata.");
            }
            else
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
                        throw new CodigoInvalidoException("\nCódigo inválido. Intentelo nuevamente.");
                }
                this._latas.Add(lata);
                this._capacidad = _capacidad - 1;
                lata.Precio = precio;
                lata.Volumen = volumen;
            }

        }
        public Lata ExtraerLata(string codigo, double dinero)
        {
            if (this.EstaVacia() == true)
            {
                throw new SinStockException("La Expendedora está sin stock en estos mommentos.");
            }
            else
            {
                Lata lata;

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
                        throw new CodigoInvalidoException("\nCódigo inválido. Intentelo nuevamente.");
                }
            }
            return ;
        }
        //public string GetBalance()
        //{

        //}
        public int GetCapacidadRestante()
        {
            return 60 - this._capacidad;
        }
        public void EncenderMaquina()
        {
            _encendida = true;
            Console.WriteLine("Máquina Encendida!");
            Console.WriteLine("\nIngrese una tecla para volver al Menú Pricipal.");
            Console.ReadKey();
            
        }
        public bool EstaVacia()
        {
            if (this._capacidad == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
