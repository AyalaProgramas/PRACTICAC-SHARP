using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Avion:Vehiculo,IAFIP
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velocidad)
            : base(precio)
        {
            this._velocidadMaxima = velocidad;
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.33;
        }
    }
}
