using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Conexion;

namespace TallerMantenimiento.Control
{
    class CtrlCliente
    {
        private static CtrlCliente ctrlCliente = null;
        private List<Cliente> lstCliente { get; set; }
        private Cliente clt;
        private ConexionDB conexionDB;


        public CtrlCliente()
        {
            conexionDB = new ConexionDB();
        }

        public Boolean noVacio(string nombre, string apellido, string cedula,
            string correo, string telefono)
        {
            bool bnd = true;
            if (String.IsNullOrEmpty(nombre)
                || String.IsNullOrEmpty(apellido)
                || String.IsNullOrEmpty(cedula)
                || String.IsNullOrEmpty(correo)
                || String.IsNullOrEmpty(telefono))
            {
                bnd = false;
            }
            else
            {
                bnd = true;
            }
            return bnd;
        }

        public Boolean IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AgregarCliente(string nombre, string apellido, string cedula, string correo, string telefono)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_CLIENTE_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "C");
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                    cmd.Parameters.AddWithValue("@CEDULA", cedula);
                    cmd.Parameters.AddWithValue("@CORREO", correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", telefono);

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

        public void ActualizarCliente(int id, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_CLIENTE_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "U");
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", apellido);
                    cmd.Parameters.AddWithValue("@CEDULA", cedula);
                    cmd.Parameters.AddWithValue("@CORREO", correo);
                    cmd.Parameters.AddWithValue("@TELEFONO", telefono);

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

        public void EliminarCliente(int id)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_CLIENTE_CRUD", conexionDB.GetConexion()))
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

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_CLIENTE_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente(0,"","","","","");
                            cliente.Id = Convert.ToInt32(reader["ID"]);
                            cliente.Nombre = reader["NOMBRE"].ToString();
                            cliente.Apellido = reader["APELLIDO"].ToString();
                            cliente.Cedula = reader["CEDULA"].ToString();
                            cliente.Correo = reader["CORREO"].ToString();
                            cliente.Telefono = reader["TELEFONO"].ToString();
                            listaClientes.Add(cliente);
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

            return listaClientes;
        }


        public Cliente ObtenerClientePorID(int id)
        {
            Cliente cliente = new Cliente(0, "", "", "", "", "");

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_CLIENTE_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente.Id = Convert.ToInt32(reader["ID"]);
                            cliente.Nombre = reader["NOMBRE"].ToString();
                            cliente.Apellido = reader["APELLIDO"].ToString();
                            cliente.Cedula = reader["CEDULA"].ToString();
                            cliente.Correo = reader["CORREO"].ToString();
                            cliente.Telefono = reader["TELEFONO"].ToString();

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

            return cliente;
        }


        public static CtrlCliente GetCtrlCliente()
        {
            if (ctrlCliente == null)
            {
                ctrlCliente = new CtrlCliente();
            }

            return ctrlCliente;
        }


    }
}
