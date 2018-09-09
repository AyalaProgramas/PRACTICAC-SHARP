using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Deportivo:Auto,IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int cf)
            : base(precio, patente)
        {
            this._caballosFuerza = cf;
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.28;
        }
    }
}
