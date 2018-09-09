using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public Auto()
        { }

        public static bool operator ==(Auto a, Auto b)
        {
            return a._marca == b._marca && a._color == b._color;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return (obj is Auto) && this==obj;
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Marca: " + this._marca);
            //sb.AppendLine("Color: " + this._color);
            return "Marca: " + this._marca + " -- Color: " + this._color;
        }
    }
}
