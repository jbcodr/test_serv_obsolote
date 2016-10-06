using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static General.Enumeraciones;

namespace Company
{
    public class Transcripcion
    {
        private int idTranscripcion;
        private string login;
        private EstadoTranscripcion estado;
        private string nombreFichero;
        private byte[] fichero;
        private DateTime fechaRecepcion;
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
        /// Property Estado
        /// </summary>
        public EstadoTranscripcion Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        /// <summary>
        /// Property NombreFichero
        /// </summary>
        public string NombreFichero
        {
            get { return nombreFichero; }
            set { nombreFichero = value; }
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
