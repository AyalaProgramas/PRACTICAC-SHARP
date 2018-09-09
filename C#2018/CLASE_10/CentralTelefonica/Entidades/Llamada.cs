using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Llamada
    {
        #region "Fields"
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor parametrizado que instancia los atributos
        /// </summary>
        /// <param name="origen">Es el valor a asignar al atributo _nroOrigen</param>
        /// <param name="destino">Es el valor a asignar al atributo _nroDestino</param>
        /// <param name="duracion">Es el valor a asignar al atributo _duracion</param>
        public Llamada(string origen,string destino,float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
        #endregion

        #region "Properties"
        /// <summary>
        /// Propiedad de solo lectura que retorna el valor del atributo _duracion
        /// </summary>
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna el valor del atributo _nroDestino
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna el valor del atriburo _nroOrigen
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        #endregion

        #region "Methods"
        /// <summary>
        /// Metodo que recibe dos llamadas y compara sus atributos _duracion
        /// devolviendo un entero de acuerdo al resultado de dicha comparacion
        /// </summary>
        /// <param name="uno">Es la primer llamada a comparar</param>
        /// <param name="dos">Es la segunda llamada a comparar</param>
        /// <returns>1 en caso de que la primer llamada es mayor,-1 en caso contrario
        /// y 0 ante igualdad</returns>
        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            int retorno = 0;

            if (uno._duracion > dos._duracion)
                retorno = 1;

            if (uno._duracion < dos._duracion)
                retorno = -1;

            return retorno;
        }
        /// <summary>
        /// Método que retorna un string cargado con los valores de los atributos de la llamada
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("---------------------------------");
            cadena.AppendLine("Nro Origen: " + this._nroOrigen);
            cadena.AppendLine("Nro Destino: " + this._nroDestino);
            cadena.AppendLine("Duracion: " + this._duracion);

            return cadena.ToString();
        }
        #endregion

    }
}
