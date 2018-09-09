using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Centralita
    {
#region "Fields"
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion
        
        #region "Properties"
        /* Nota: Las propiedads GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado
         * seún el criterio. Se claculará en el método CalcularGanancia(). 
         */
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
               return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamada
        {            
            get
            {
                return this._listaDeLlamadas;
            }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor por defecto que inicializa la lista de llamadas
        /// </summary>
        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
            
        }
        /// <summary>
        /// Constructor parametrizado,recibe la razon social como parámetro
        /// </summary>
        /// <param name="razonSocial"></param>
        public Centralita(string razonSocial):this()
        {           
            this._razonSocial = razonSocial;
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Calcula la ganancia de acuerdo al tipo de llamada recibida.Retornando el valor de lo recaudado según criterio
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            // Variable para ir acumulando los costos de las ganancias
            float gananciaLocal = 0;
            float gananciaProv = 0;
            float gananciaTotal = 0;

            // Recorro la lista buscando coincidencia de tipo de llamada
           foreach(Llamada i in this._listaDeLlamadas) 
            {
                // Ante la igualdad de tipo incremento el acumulador 
                if(i is Local)
                {
                    gananciaLocal += ((Local)i).CostoLlamada;
                    gananciaTotal += ((Local)i).CostoLlamada;
                }
                if(i is Provincial)
                {
                    gananciaProv += ((Provincial)i).CostoLlamada;
                    gananciaTotal += ((Provincial)i).CostoLlamada;
                }                
            }
            if (tipo == TipoLlamada.Local)
                return gananciaLocal;
            else if (tipo == TipoLlamada.Provincial)
                return gananciaProv;
            else
                return gananciaTotal;
        } 
        /// <summary>
        /// Metodo que muestra a través de un string 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Razon Social: "+this._razonSocial);
            cadena.AppendLine("Ganancia Total: "+this.GananciaTotal);
            cadena.AppendLine("Ganancia Llamadas Locales: "+this.GananciaPorLocal); 
            cadena.AppendLine("Ganancia Llamadas Provinciales: "+this.GananciaPorProvincial);
            cadena.AppendLine("********************************************");
            cadena.AppendLine("Detalle de Llamadas Realizadas: ");

            foreach(Llamada i in this._listaDeLlamadas)
            {
                if (i is Local)
                    cadena.AppendLine(((Local)i).Mostrar());
                else
                    cadena.AppendLine(((Provincial)i).Mostrar());
            }
            return cadena.ToString();
        }

        /*Nota: El método de clase OrdenarPorDuracion será utilizado en el método Sort de la lista genérica de objetos del mismo tipo
         * (en la clase Centralita). */
         public void OrdenarLlamadas()
        {
           // this._listaDeLlamadas.Sort()
            
            //Llamada.OrdenarPorDuracion(uno, dos);
        }
#endregion

    }
}
