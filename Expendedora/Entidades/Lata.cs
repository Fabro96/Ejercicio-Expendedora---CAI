using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        public Lata(string _codigo, string _nombre, string _sabor)
        {
            this._codigo = _codigo;
            this._nombre = _nombre;
            this._sabor = _sabor;

        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Sabor
        {
            get { return _sabor; }
            set { _sabor = value; }
        }

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public double Volumen
        {
            get { return _volumen; }
            set { _volumen = value; }
        }




        public double GetPrecioPorLitro()
        {
            return _precio;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} - {1} $ {2} / $/L {3}", this._nombre, this._sabor);
        //}
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this._codigo, this._nombre, this._sabor);
        }

        //public string Codigos()
        //{
        //    return string.Format("{0}", this._codigo);
        //}
    }
}
