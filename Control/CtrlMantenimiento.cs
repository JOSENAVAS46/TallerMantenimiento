using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Conexion;

namespace TallerMantenimiento.Control
{
    class CtrlMantenimiento
    {
        private static CtrlMantenimiento ctrlMantenimiento = null;
        private List<Mantenimiento> lstMantenimientos { get; set; }
        private Mantenimiento mnt = null;
        private ConexionDB conexionDB;


        public CtrlMantenimiento()
        {
            conexionDB = new ConexionDB();
        }


        public Boolean noVacio(Cliente cliente,
            Mecanico mecanico,
            Vehiculo vehiculo,
            DateTime fecha,
            string diagnostico,
            string tipo)
        {
            bool bnd = true;
            if (cliente != null ||
                mecanico != null ||
                vehiculo != null ||
                String.IsNullOrEmpty(diagnostico) ||
                String.IsNullOrEmpty(tipo)
            )
            {
                bnd = true;
            }
            else
            {
                bnd = false;
            }
            return bnd;
        }


        public void GuardarMantenimiento(Mantenimiento mant)
        {
            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MANTENIMIENTO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "C");
                    cmd.Parameters.AddWithValue("@CODIGO", mant.Codigo);
                    cmd.Parameters.AddWithValue("@CLIENTE_ID", mant.Cliente.Id);
                    cmd.Parameters.AddWithValue("@MECANICO_ID", mant.Mecanico.Id);
                    cmd.Parameters.AddWithValue("@VEHICULO_ID", mant.Vehiculo.Id);
                    cmd.Parameters.AddWithValue("@FECHA_MANTENIMIENTO", mant.FechaMantenimiento);
                    cmd.Parameters.AddWithValue("@DIAGNOSTICO", mant.Diagnostico);
                    cmd.Parameters.AddWithValue("@TIPO", mant.Tipo);
                    cmd.Parameters.AddWithValue("@PRECIO", mant.Precio);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mantenimiento Registrado Exitosamente.");
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

        public List<Mantenimiento> ObtenerMantenimientos()
        {
            List<Mantenimiento> listaMantenimientos = new List<Mantenimiento>();

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MANTENIMIENTO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear un objeto Mantenimiento y llenarlo con los datos del SqlDataReader
                            Cliente cliente = new Cliente(0,"","","","","");
                            Mecanico mecanico = new Mecanico(0,"","","","",0.0);
                            Vehiculo vehiculo = new Vehiculo("","","","");
                            List<Repuesto> repuestos = new List<Repuesto>();
                            List<Servicio> servicios = new List<Servicio>();
                            Mantenimiento mantenimiento = new Mantenimiento( cliente, mecanico, vehiculo, DateTime.Now, "","", repuestos, servicios);
                            mantenimiento.Id = Convert.ToInt32(reader["ID"]);
                            mantenimiento.Codigo = reader["Codigo"].ToString();
                            mantenimiento.Cliente = CtrlCliente.GetCtrlCliente().ObtenerClientePorID(Convert.ToInt32(reader["ClienteID"]));
                            mantenimiento.Mecanico = CtrlMecanico.GetCtrlMecanico().ObtenerMecanicoPorID(Convert.ToInt32(reader["MecanicoID"]));
                            mantenimiento.Vehiculo = CtrlVehiculo.GetCtrlVehiculo().ObtenerVehiculoPorID(Convert.ToInt32(reader["VehiculoID"]));
                            mantenimiento.FechaMantenimiento = Convert.ToDateTime(reader["FechaMantenimiento"]);
                            mantenimiento.Diagnostico = reader["Diagnostico"].ToString();
                            mantenimiento.Tipo = reader["Tipo"].ToString();
                            mantenimiento.Precio = Convert.ToDouble(reader["Precio"]);
                            listaMantenimientos.Add(mantenimiento);
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

            return listaMantenimientos;
        }

        public Mantenimiento ObtenerMantenimientoPorID(int id)
        {
            Mantenimiento mantenimiento = null;

            try
            {
                conexionDB.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_MANTENIMIENTO_CRUD", conexionDB.GetConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ACCION", "R");
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
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

            return mantenimiento;
        }


        public static CtrlMantenimiento GetCtrlMantenimiento()
        {
            if (ctrlMantenimiento ==  null)
            {
                ctrlMantenimiento = new CtrlMantenimiento();
            }
            return ctrlMantenimiento;
        }
    }
}
