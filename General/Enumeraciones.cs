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
        internal enum TipoNumero
        {
            Boolean,
            Byte,
            Int16,
            Int32,
            Int64,
            UInt16,
            UInt32,
            UInt64,
            Single,
            Double,
            Decimal,
        }
    }
}
