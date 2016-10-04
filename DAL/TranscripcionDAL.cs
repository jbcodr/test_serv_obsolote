// Author - Anshu Dutta
// Contact - anshu.dutta@gmail.com
using System;
using Company;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using General;

namespace DAL
{
    public class TranscripcionDAL
    {
        private SqlConnection conn;
        private static string connString;
        private SqlCommand command;       
        private ErrorHandler.ErrorHandler err;

        public TranscripcionDAL(string _connString)
        {
            err = new ErrorHandler.ErrorHandler();
            connString = _connString;            
        }
        /// <summary>
        /// Database INSERT Transcripcion
        /// </summary>
        /// <param name="transcripcion"></param>
        public int Insert(Transcripcion transcripcion)
        {
            try
            {
                string sqlInserString = "INSERT INTO Transcripcion (Login, Fichero, FechaRecepcion, Estado, FechaTranscripcion, TextoTranscripcion) VALUES (@Login, @Fichero, @FechaRecepcion, @Estado, @FechaTranscripcion, @TextoTranscripcion);"
                    + " SELECT SCOPE_IDENTITY();";

                conn = new SqlConnection(connString);
                command = new SqlCommand(sqlInserString, conn);
                command.Connection = conn;
                command.Parameters.Add(new SqlParameter("@Login", transcripcion.Login));
                command.Parameters.Add(new SqlParameter("@Fichero", transcripcion.Fichero));
                command.Parameters.Add(new SqlParameter("@FechaRecepcion", transcripcion.FechaRecepcion));
                command.Parameters.Add(new SqlParameter("@Estado", transcripcion.Estado));
                command.Parameters.Add(new SqlParameter("@FechaTranscripcion", (object)transcripcion.FechaRecepcion ?? DBNull.Value));
                command.Parameters.Add(new SqlParameter("@TextoTranscripcion", transcripcion.Login));

                command.Connection.Open();
                int id = Numeros.ToInt(command.ExecuteScalar());
                command.Connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                err.ErrorMessage = ex.Message.ToString();
                throw;
            }
        }
        /// <summary>
        /// Database UPDATE Transcripcion
        /// </summary>
        /// <param name="transcripcion"></param>
        public void Update(Transcripcion transcripcion)
        {
            try
            {
                string sqlUpdateString = "UPDATE Transcripcion SET Login = @Login, Fichero = @Fichero, FechaRecepcion = @FechaRecepcion, Estado = @Estado, FechaTranscripcion = @FechaTranscripcion, TextoTranscripcion = @TextoTranscripcion WHERE IdTranscripcion = @IdTranscripcion;";

                conn = new SqlConnection(connString);
                command = new SqlCommand(sqlUpdateString, conn);
                command.Connection = conn;
                command.Parameters.Add(new SqlParameter("@IdTranscripcion", transcripcion.IdTranscripcion));
                command.Parameters.Add(new SqlParameter("@Login", transcripcion.Login));
                command.Parameters.Add(new SqlParameter("@Fichero", transcripcion.Fichero));
                command.Parameters.Add(new SqlParameter("@FechaRecepcion", transcripcion.FechaRecepcion));
                command.Parameters.Add(new SqlParameter("@Estado", transcripcion.Estado));
                command.Parameters.Add(new SqlParameter("@FechaTranscripcion", (object)transcripcion.FechaRecepcion ?? DBNull.Value));
                command.Parameters.Add(new SqlParameter("@TextoTranscripcion", transcripcion.Login));
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                err.ErrorMessage = ex.Message.ToString();
                throw;
            }
        }
        /// <summary>
        /// Database DELETE Transcripcion
        /// </summary>
        /// <param name="idTranscripcion"></param>
        public void Delete(int idTranscripcion)
        {
            try
            {
                string sqlDeleteString = "DELETE FROM Transcripcion WHERE IdTranscripcion = @IdTranscripcion;";

                conn = new SqlConnection(connString);
                command = new SqlCommand(sqlDeleteString, conn);
                command.Connection = conn;
                command.Parameters.Add(new SqlParameter("@IdTranscripcion", idTranscripcion));
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                err.ErrorMessage = ex.Message.ToString();
                throw;
            }
        }
        /// <summary>
        /// Database SELECT Transcripcion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Transcripcion Select(int idTranscripcion)
        {
            try
            {
                Transcripcion transcripcion = null;
                string sqlSelectString = "SELECT IdTranscripcion, Login, Fichero, FechaRecepcion, Estado, FechaTranscripcion, TextoTranscripcion FROM Transcripcion WHERE IdTranscripcion = @IdTranscripcion;";

                conn = new SqlConnection(connString);
                command = new SqlCommand(sqlSelectString, conn);
                command.Connection = conn;
                command.Parameters.Add(new SqlParameter("@IdTranscripcion", idTranscripcion));
                command.Connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dt = new DataTable("Table1");
                if (dataReader != null) { dt.Load(dataReader); }
                command.Connection.Close();
                if (dt.Rows.Count>0)
                {
                    DataRow dr = dt.Rows[0];
                    transcripcion = new Transcripcion();
                    transcripcion.IdTranscripcion = Numeros.ToInt(dr["IdTranscripcion"]);
                    transcripcion.Login = dr["Login"].ToString();
                    transcripcion.Fichero = (byte[])dr["Fichero"];

                }

                return transcripcion;
            }
            catch (Exception ex)
            {
                err.ErrorMessage = ex.Message.ToString();
                throw;
            }
        }
        /// <summary>
        /// Database SELECT with filters Transcripcion
        /// </summary>
        /// <returns>Transcripcion</returns>
        private List<Transcripcion> SelectFilters()
        {
            try
            {
                List<Transcripcion> lista = new List<Transcripcion>();

                conn = new SqlConnection(connString);

                string sqlSelectString = "SELECT IdTranscripcion, Login, Fichero, FechaRecepcion, Estado, FechaTranscripcion, TextoTranscripcion FROM Transcripcion";
                command = new SqlCommand(sqlSelectString, conn);
                command.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    Employee emp = new Employee();
                //    emp.FirstName = reader[0].ToString();
                //    emp.LastName = reader[1].ToString();
                //    emp.EmpCode = Convert.ToInt16(reader[2]);
                //    emp.Designation = reader[3].ToString();
                //    empList.Add(emp);
                //}
                //command.Connection.Close();

                return lista;
            }
            catch (Exception ex)
            {
                err.ErrorMessage = ex.Message.ToString();
                throw;
            }
        }
        /// <summary>
        /// Get Exception if any
        /// </summary>
        /// <returns> Error Message</returns>
        public string GetException()
        {
            return err.ErrorMessage.ToString();
        }
    }
}
