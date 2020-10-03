using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Lata
    {
        //ATRIBUTOS
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        //CONSTRUCTOR
        public Lata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
            this._precio = precio;
            this._volumen = volumen;
        }

        //PROPIEDADES
        public string Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public string Sabor
        {
            set { _sabor = value; }
            get { return _sabor;  }
        }
        public double Precio
        {
            set { _precio = value; }
            get { return _precio;  }
        }
        public double Volumen
        {
            set { _volumen = value; }
            get { return _volumen;  }
        }

        //MÉTODOS
        private double GetPrecioPorLitro()
        {
           
            return 50.5;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - $ {2} / $/l {3}", this._nombre, this._sabor, this._precio, GetPrecioPorLitro());
        }


    }
}
