using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class PeliculaADO
    {
        ConexionADO conexionADO = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public Boolean crearPelicula(Pelicula pelicula)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_CrearPelicula";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_dir", pelicula.IdDirector);
                command.Parameters.AddWithValue("@vnom", pelicula.Nombre);
                command.Parameters.AddWithValue("@vgen", pelicula.Genero);
                command.Parameters.AddWithValue("@vsin", pelicula.Sinopsis);
                command.Parameters.AddWithValue("@vfch_est", pelicula.FchEstreno);

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

        public List<Pelicula> listarPeliculas()
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_listarPeliculas";

            try
            {
                List<Pelicula> peliculas = new List<Pelicula>();

                command.Parameters.Clear();

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Pelicula pelicula = new Pelicula();

                    pelicula.IdPelicula = Convert.ToInt16(dataReader["IdPelicula"]);
                    pelicula.IdDirector = Convert.ToInt16(dataReader["IdDirector"]);
                    pelicula.Nombre = dataReader["Nombre"].ToString();
                    pelicula.Genero = dataReader["Genero"].ToString();
                    pelicula.Sinopsis = dataReader["Sinopsis"].ToString();
                    pelicula.FchEstreno = Convert.ToDateTime(dataReader["FchEstreno"]);

                    peliculas.Add(pelicula);
                }
                return peliculas;
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

        public Boolean actualizarPeliculas(Pelicula pelicula)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_ActualizarPelicula";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_dir", pelicula.IdDirector);
                command.Parameters.AddWithValue("@vnom", pelicula.Nombre);
                command.Parameters.AddWithValue("@vgen", pelicula.Genero);
                command.Parameters.AddWithValue("@vsin", pelicula.Sinopsis);
                command.Parameters.AddWithValue("@vfch_est", pelicula.FchEstreno);
                command.Parameters.AddWithValue("@vid_pel", pelicula.IdPelicula);

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

        public Boolean eliminarPelicula(int id)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_EliminarPelicula";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_pel", id);

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

        public List<Pelicula> listarPeliculasPorDirector(int id)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_listarPeliculasPorDirector";

            try
            {
                List<Pelicula> peliculas = new List<Pelicula>();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_dir", id);

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Pelicula pelicula = new Pelicula();

                    pelicula.IdPelicula = Convert.ToInt16(dataReader["IdPelicula"]);
                    pelicula.IdDirector = Convert.ToInt16(dataReader["IdDirector"]);
                    pelicula.Nombre = dataReader["Nombre"].ToString();
                    pelicula.Genero = dataReader["Genero"].ToString();
                    pelicula.Sinopsis = dataReader["Sinopsis"].ToString();
                    pelicula.FchEstreno = Convert.ToDateTime(dataReader["FchEstreno"]);

                    peliculas.Add(pelicula);
                }
                return peliculas;
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

        public Pelicula findPeliculaById(int id)
        {
            connection.ConnectionString = conexionADO.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_FindPeliculaById";

            try
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vid_pel", id);

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                Pelicula pelicula = new Pelicula();

                while (dataReader.Read())
                {
                    pelicula.IdPelicula = Convert.ToInt16(dataReader["IdPelicula"]);
                    pelicula.IdDirector = Convert.ToInt16(dataReader["IdDirector"]);
                    pelicula.Nombre = dataReader["Nombre"].ToString();
                    pelicula.Genero = dataReader["Genero"].ToString();
                    pelicula.Sinopsis = dataReader["Sinopsis"].ToString();
                    pelicula.FchEstreno = Convert.ToDateTime(dataReader["FchEstreno"]);
                }
                return pelicula;

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