using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Conexion;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Control
{
    class CtrlMecanico
    {
        private static CtrlMecanico ctrlMecanico = null;
        private ConexionDB conexionDB;

        public CtrlMecanico()
        {
            conexionDB = new ConexionDB();
        }


        public Boolean noVacio(string nombre, string apellido, string cedula,
            string especialidad, double salario)
        {
            bool bnd = true;
            if (String.IsNullOrEmpty(nombre)
                || String.IsNullOrEmpty(apellido)
                || String.IsNullOrEmpty(cedula)
                || String.IsNullOrEmpty(especialidad)
                || salario < 0)
            {
                bnd = false;
            }
            else
            {
                bnd = true;
            }
            return bnd;
        }

        public List<Mecanico> ObtenerMecanicos()
        {
            List<Mecanico> listaMecanicos = new List<Mecanico>();

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MECANICO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mecanico mecanico = new Mecanico(0, "", "", "", "", 0);
                            mecanico.Id = Convert.ToInt32(reader["ID"]);
                            mecanico.Nombre = reader["NOMBRE"].ToString();
                            mecanico.Apellido = reader["APELLIDO"].ToString();
                            mecanico.Cedula = reader["CEDULA"].ToString();
                            mecanico.Especialidad = reader["ESPECIALIDAD"].ToString();
                            mecanico.Salario = Convert.ToDouble(reader["SALARIO"]);
                            listaMecanicos.Add(mecanico);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            finally
            {
                conexionDB.CerrarConexion();
            }

            return listaMecanicos;
        }

        public Mecanico ObtenerMecanicoPorID(int id)
        {
            Mecanico mecanico = new Mecanico(0, "", "", "", "", 0);

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MECANICO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mecanico.Id = Convert.ToInt32(reader["ID"]);
                            mecanico.Nombre = reader["NOMBRE"].ToString();
                            mecanico.Apellido = reader["APELLIDO"].ToString();
                            mecanico.Cedula = reader["CEDULA"].ToString();
                            mecanico.Especialidad = reader["ESPECIALIDAD"].ToString();
                            mecanico.Salario = Convert.ToDouble(reader["SALARIO"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            finally
            {
                conexionDB.CerrarConexion();
            }

            return mecanico;
        }

        public void AgregarMecanico(string nombre, string apellido, string cedula, string especialidad, double salario)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MECANICO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "C");
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                    cmd.Parameters.AddWithValue("@CEDULA", cedula);
                    cmd.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);
                    cmd.Parameters.AddWithValue("@SALARIO", salario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        public void ActualizarMecanico(int id, string nombre, string apellido, string cedula, string especialidad, double salario)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MECANICO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "U");
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                    cmd.Parameters.AddWithValue("@CEDULA", cedula);
                    cmd.Parameters.AddWithValue("@ESPECIALIDAD", especialidad);
                    cmd.Parameters.AddWithValue("@SALARIO", salario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }

        public void EliminarMecanicoPorId(int id)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MECANICO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "D");
                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            finally
            {
                conexionDB.CerrarConexion();
            }
        }


        public static CtrlMecanico GetCtrlMecanico()
        {
            if (ctrlMecanico == null)
            {
                ctrlMecanico = new CtrlMecanico();
            }

            return ctrlMecanico;
        }
    }
}

