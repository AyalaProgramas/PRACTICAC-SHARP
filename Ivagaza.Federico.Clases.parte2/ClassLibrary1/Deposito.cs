using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Deposito<T>where T:new()
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito()
        {
            this._lista = new List<T>();
        }

        public Deposito(int capacidad):this()
        {
            if (capacidad > 50)
            {
                throw new MyClassException("el deposito no puede ser supieror a 50");
            }
            else if (capacidad < 1)
            {
                throw new MyClassException("el deposito no puede tener menos de un espacio");
            }
            else
            {
                this._capacidadMaxima = capacidad;
            }
            
        }

        public List<T> Lista
        {
            get { return this._lista; }
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            else
            {
                throw new MyClassException("El deposito esta lleno");
            }
            return retorno;
        }

        private int GetIndice(T a)
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

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                retorno = true;
            }
            return retorno;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad Maxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de "+typeof(T).Name);
            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
