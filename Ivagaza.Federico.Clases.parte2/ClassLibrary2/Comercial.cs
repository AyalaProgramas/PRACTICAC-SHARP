using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Comercial:Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int cantPasajeros)
            : base(precio, velocidad)
        {
            this._capacidadPasajeros = cantPasajeros;
        }
    }
}
