using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Provincial:Llamada
    {
#region "Fields"
        protected Franja _franjaHoraria;
        #endregion

        #region "Properties"
        /// <summary>
        /// Propiedad de solo lectura que retorna un float con el valor de la llamada 
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
                
        }
        #endregion

        #region "Constructor y Sobrecarga del mismo"
        /// <summary>
        /// Sobrecarga del constructor que invoca a éste para inicializarlo con los valores que recibe de un primer parámetro objeto
        /// de tipo Llamada más el segundo parámetro Franja
        /// </summary>
        /// <param name="miFranja"></param>
        /// <param name="unaLlamada"></param>
        public Provincial(Franja miFranja,Llamada unaLlamada):this(unaLlamada.NroOrigen,miFranja,unaLlamada.Duracion,unaLlamada.NroDestino)
        {
            // No lleva código porque invoca al constructor por default
        }
        /// <summary>
        /// Constructor por defecto parametrizado que invoca al constructor de la clase padre
        /// asignándole el valor a los atributos de la clase base y al atributo único de clase
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="miFranja"></param>
        /// <param name="duracion"></param>
        /// <param name="destino"></param>
        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }
        #endregion

        #region "Methods"

        /// <summary>
        /// Método que retorna el valor de la llamada a partir de la duración de la misma y la franja horaria
        /// </summary>
        /// <returns>El valor de la llamada en un dato de tipo float</returns>
        private float CalcularCosto()// Preguntar si a las constantes se les pasa f de float
        {
            float costoPorSeg = 0;

            switch(this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costoPorSeg = 0.99f;
                    break;
                case Franja.Franja_2:
                    costoPorSeg = 1.25f;
                    break;
                case Franja.Franja_3:
                    costoPorSeg = 0.66f;
                    break;
                default:
                    costoPorSeg = 0;
                    break;
            }

            return this.Duracion * costoPorSeg;
        }
        /// <summary>
        /// Método público que retorna un string mostrando los atributos heredados más el atributo propio y el costo de la llamada
        /// </summary>
        /// <returns>Una cadena con la información concatenada </returns>
        public new string Mostrar()// Agrego el prefijo new para que no marque posible error
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append(base.Mostrar());
            cadena.AppendLine("Franja Horaria: "+(Franja)this._franjaHoraria);// Ver si esto está bien OJO ***************************
            cadena.AppendFormat("Costo Llamada: $ {0}", this.CostoLlamada);

            return cadena.ToString();
        }
        #endregion

    }
}
