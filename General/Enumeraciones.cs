using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace General
{
    public class Enumeraciones
    {
        /// <summary>
        /// Enumeración de los estados de una transcripción.
        /// </summary>
        public enum EstadoTranscripcion
        {
            Pendiente,
            EnProceso,
            Realizada,
            Error,
        }
    }
}
