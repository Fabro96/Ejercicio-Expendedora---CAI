using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class Lata
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

        public double GetPrecioPorLitro()
        {
            return _precio;
        }

        //public override string ToString()
        //{
        //    return string.Format("{nombre} - {sabor} $ {precio} / $/L {precio por litro}", this._nombre, this._sabor);
        //}
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this._codigo, this._nombre, this._sabor);
        }


    }
}
