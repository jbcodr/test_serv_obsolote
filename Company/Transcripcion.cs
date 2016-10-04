// Author - Anshu Dutta
// Contact - anshu.dutta@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Transcripcion
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

        private int idTranscripcion;
        private string login;
        private byte[] fichero;
        private DateTime fechaRecepcion;
        private EstadoTranscripcion estado;
        private DateTime? fechaTranscripcion;   // Declaramos como DateTime? para permitir valores null.
        private string textoTranscripcion;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Transcripcion()
        { }
        /// <summary>
        /// Property IdTranscripcion
        /// </summary>
        public int IdTranscripcion
        {
            get { return idTranscripcion; }
            set { idTranscripcion = value; }
        }
        /// <summary>
        /// Property Login
        /// </summary>
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        /// <summary>
        /// Property Fichero
        /// </summary>
        public byte[] Fichero
        {
            get { return fichero; }
            set { fichero = value; }
        }        
        /// <summary>
        /// Property FechaRecepcion
        /// </summary>
        public DateTime FechaRecepcion
        {
            get { return fechaRecepcion; }
            set { fechaRecepcion = value; }
        }
        /// <summary>
        /// Property Estado
        /// </summary>
        public EstadoTranscripcion Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Property FechaTranscripcion
        /// </summary>
        public DateTime? FechaTranscripcion
        {
            get { return fechaTranscripcion; }
            set { fechaTranscripcion = value; }
        }
        /// <summary>
        /// Property TextoTranscripcion
        /// </summary>
        public string TextoTranscripcion
        {
            get { return textoTranscripcion; }
            set { textoTranscripcion = value; }
        }
    }
}
