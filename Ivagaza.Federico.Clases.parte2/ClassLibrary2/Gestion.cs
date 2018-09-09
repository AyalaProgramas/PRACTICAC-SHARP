using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public sealed class Gestion
    {
        public double MostrarImpuestoNacional(IAFIP bienPulible)
        {
            return bienPulible.CalcularImpuesto();
        }
    }
}
