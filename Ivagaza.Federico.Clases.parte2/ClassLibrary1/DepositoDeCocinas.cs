using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas()
        {
            this._lista = new List<Cocina>();
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Cocina a)
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

        public static bool operator -(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;
            if (d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad Maxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de cocinas:");
            foreach (Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
