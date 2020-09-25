using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Lata
    {
        string _codigo;
        string _nombre;
        string _sabor;
        double _precio;
        double _volumen;

        public Lata(string codigo, string nombre, string sabor)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
        }

        public double GetPrecioPorLitro(double precio, double volumen)
        {
            //Ingresar Precio //Ingresar Volumen
            double precioPorLitro = (precio / volumen);
            return double.Parse(precioPorLitro + "$/L");
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} - {1} $ {2} / $/L {3}", this._nombre, this._sabor, this._precio, this.GetPrecioPorLitro());
        //}


    }
}
