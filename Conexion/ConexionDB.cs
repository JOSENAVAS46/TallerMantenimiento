using System.Data;
using System.Data.SqlClient;


namespace TallerMantenimiento.Conexion
{
    public class ConexionDB
    {
        public SqlConnection conexion;

        public ConexionDB()
        {
             conexion = new SqlConnection("Data Source=localhost;Initial Catalog=TallerMantenimientoBD;Integrated Security=True");
        }

        public void AbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }

        }

        public void CerrarConexion()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public SqlConnection GetConexion()
        {
            return conexion;
        }


    }
}
