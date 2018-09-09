using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public Cocina(int codigo, double precio, bool industrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = industrial;
        }

        public Cocina()
        { }

        public int Codigo
        {
            get { return this._codigo; }
        }

        public bool esIndustrial
        {
            get { return this._esIndustrial; }
        }

        public double Precio
        {
            get { return this._precio; }
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return a._codigo == b._codigo;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return (obj is Cocina) && this == obj;
        }

        public override string ToString()
        {
            return "Codigo: " + this._codigo + " -- Precio: " + this._precio + " -- es Industrial? " + this._esIndustrial;
        }
    }
}
