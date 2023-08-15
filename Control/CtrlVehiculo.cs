using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Conexion;
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Control
{
    class CtrlVehiculo
    {
        private static CtrlVehiculo ctrlVehiculo = null;
        private ConexionDB conexionDB;

        public CtrlVehiculo()
        {
            conexionDB = new ConexionDB();
        }

        //Metodo no vacio para Vehiculo
        public Boolean noVacio(string placa, string marca, 
            string modelo, string color)
        {
            bool bnd = true;
            if (String.IsNullOrEmpty(placa) ||
                String.IsNullOrEmpty(marca) ||
                String.IsNullOrEmpty(modelo) ||
                String.IsNullOrEmpty(color))
            {
                bnd = false;
            }
            else
            {
                bnd = true;
            }
            return bnd;
        }

        //Metodo para guardar Vehiculo
        public void AgregarVehiculo(string placa, string marca, string modelo, string color)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_VEHICULO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "C");
                    cmd.Parameters.AddWithValue("@PLACA", placa);
                    cmd.Parameters.AddWithValue("@MARCA", marca);
                    cmd.Parameters.AddWithValue("@MODELO", modelo);
                    cmd.Parameters.AddWithValue("@COLOR", color);

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

        public List<Vehiculo> ObtenerVehiculos()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_VEHICULO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehiculo vehiculo = new Vehiculo("","","","");
                            vehiculo.Id = Convert.ToInt32(reader["ID"]);
                            vehiculo.Placa = reader["PLACA"].ToString();
                            vehiculo.Marca = reader["MARCA"].ToString();
                            vehiculo.Modelo = reader["MODELO"].ToString();
                            vehiculo.Color = reader["COLOR"].ToString();
                            listaVehiculos.Add(vehiculo);
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

            return listaVehiculos;
        }


        public Vehiculo ObtenerVehiculoPorID(int id)
        {
            Vehiculo vehiculo = null;

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_VEHICULO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vehiculo = new Vehiculo("", "", "", "");
                            vehiculo.Id = Convert.ToInt32(reader["ID"]);
                            vehiculo.Placa = reader["PLACA"].ToString();
                            vehiculo.Marca = reader["MARCA"].ToString();
                            vehiculo.Modelo = reader["MODELO"].ToString();
                            vehiculo.Color = reader["COLOR"].ToString();
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

            return vehiculo;
        }



        public static CtrlVehiculo GetCtrlVehiculo()
        {
            if (ctrlVehiculo == null)
            {
                ctrlVehiculo = new CtrlVehiculo();
            }
            return ctrlVehiculo;
        }
    }
}
