using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos()
        {
            this._lista = new List<Auto>();
        }

        public DepositoDeAutos(int cantidad)
        {
            this._capacidadMaxima = cantidad;
            this._lista = new List<Auto>();
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int retorno = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if (d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad Maxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de autos:");
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
