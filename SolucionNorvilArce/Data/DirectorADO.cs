using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace Data
{
    public class DirectorADO
    {
        ConexionADO conexionADO = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public Boolean crearDirector(Director director)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_CrearDirector";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vape", director.Apellidos);
                command.Parameters.AddWithValue("@vnom", director.Nombres);
                command.Parameters.AddWithValue("@vpais", director.Pais);
                command.Parameters.AddWithValue("@vfec_nac", director.FchNac);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Director> listarDirectores()
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_listarDirectores";

            try
            {
                List<Director> directores = new List<Director>();

                command.Parameters.Clear();

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Director director = new Director();

                    director.IdDirector = Convert.ToInt16(dataReader["IdDirector"]);
                    director.Apellidos = dataReader["Apellidos"].ToString();
                    director.Nombres = dataReader["Nombres"].ToString();
                    director.NombreCompleto = dataReader["NombreCompleto"].ToString();
                    director.Pais = dataReader["Pais"].ToString();
                    director.FchNac = Convert.ToDateTime(dataReader["FchNac"]);

                    directores.Add(director);
                }
                return directores;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Boolean actualizarDirector(Director director)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_ActualizarDirector";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vape", director.Apellidos);
                command.Parameters.AddWithValue("@vnom", director.Nombres);
                command.Parameters.AddWithValue("@vpais", director.Pais);
                command.Parameters.AddWithValue("@vfec_nac", director.FchNac);
                command.Parameters.AddWithValue("@vid_dir", director.IdDirector);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Boolean eliminarDirector(int id)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_EliminarDirector";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_dir", id);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Director findDirectorById(int id)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_FindDirectorById";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_dir", id);

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                Director director = new Director();

                while (dataReader.Read())
                {
                    director.IdDirector = Convert.ToInt16(dataReader["IdDirector"]);
                    director.Apellidos = dataReader["Apellidos"].ToString();
                    director.Nombres = dataReader["Nombres"].ToString();
                    director.NombreCompleto = dataReader["NombreCompleto"].ToString();
                    director.Pais = dataReader["Pais"].ToString();
                    director.FchNac = Convert.ToDateTime(dataReader["FchNac"]);
                }
                return director;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
