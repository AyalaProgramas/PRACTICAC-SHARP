using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Alumno:Persona
    {
        protected int legajo;
        public Alumno(string nombre,string apellido,int id):base(nombre,apellido)
        {
            this.legajo = id;
        }

        public Alumno()
        { 
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
    }
}
