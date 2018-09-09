using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Local:Llamada
    {
#region "Fields"
        protected float _costo;
        #endregion

        #region "Properties"
        /// <summary>
        /// Propiedad de solo lectura que retorna el precio calculado en el método privado CalcularCosto
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
#endregion

        #region "Constructor y sobrecarga del mismo"
        /// <summary>
        /// Sobrecarga del constructor recibe un objeto llamada y un float costo
        /// </summary>
        /// <param name="unaLlamada">Objeto del que se leerán los valores a pasar al constructor</param>
        /// <param name="costo">Es el valor pasar al constructor para asignar al atributo único de la clase</param>
        public Local(Llamada unaLlamada,float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
            // No lleva codigo porque llama al constructor Local que llama al constructor de Llamada
        }
        /// <summary>
        /// Constructor parametrizado que invoca al constructor de la clase base y asigna los parámetros recibidos al atributo único de 
        /// la clase Local y a los atributos de la clase padre.
        /// </summary>
        /// <param name="origen">Es el valor a asignar al atributo _nroOrigen de la clase base</param>
        /// <param name="duracion">Es el valor a asignar al atributo _duracion de la clase base</param>
        /// <param name="destino">Es el valor a asignar al atributo _nroDestino de la clase base</param>
        /// <param name="costo">Es el valor a asignar al atributo _costo de la clase Local</param>
        public Local(string origen,float duracion,string destino,float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Metodo que retorna una cadena con los valores de los atributos de clase y de la clase padre concatenados
        /// </summary>
        /// <returns>Una cadena con la informacion de los atributos heredados y del atributo único de clase</returns>
        public new string Mostrar()// Le agrego el prefijo new para que no indique posible error
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append(base.Mostrar());
            cadena.AppendFormat("Costo: {0}",this.CostoLlamada);// Verificar que el formato asignado esté bien

            return cadena.ToString();
        }
        /// <summary>
        /// Método que calcula el costo de una llamada en base a la duración y el costo de la misma(de acuerdo al tipo)
        /// </summary>
        /// <returns>Un valor de tipo float que es el costo de la llamada</returns>
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }
#endregion

    }
}
