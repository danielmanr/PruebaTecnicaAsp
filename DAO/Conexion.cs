using Microsoft.Data.SqlClient;
using PruebaPro.Models;
using System.Data;
using System.Data.SqlClient;



namespace PruebaPro.DAO
{
    public class Conexion
    {

        private string cadenaConexion;
        private SqlConnection conexion;
        



        private SqlConnection ConexionAbierta()
        {
            string cadena = ClassVariables.Cadena();
            try
            {
                conexion = new SqlConnection(cadena);
                conexion.Open();

            }
            catch (SqlException e)
            {
                throw new Exception(e.ToString());
            }

            return conexion;
        }


        private void CerrarConexion()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        
        public DataTable traerDatos()
        {
            string consultaString = ClassVariables.consultaFuncionario;
            DataTable dtResultado = new DataTable();
            try
            {
                SqlCommand consulta = new SqlCommand(consultaString, ConexionAbierta());
                SqlDataAdapter adapter = new SqlDataAdapter(consulta);
                adapter.Fill(dtResultado);
                CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return dtResultado;

        }


        public DataTable buscarFuncionario(string idFuncionario)
        {
            string consultaString = ClassVariables.buscar + "like'"+idFuncionario+"%'";
            DataTable dtResultado = new DataTable();
            try
            {
                SqlCommand consulta = new SqlCommand(consultaString, ConexionAbierta());
                SqlDataAdapter adapter = new SqlDataAdapter(consulta);
                adapter.Fill(dtResultado);
                CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return dtResultado;

        }




    }
}
