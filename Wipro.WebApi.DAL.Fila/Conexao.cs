using System;
using System.Data;
using System.Data.SqlClient;

namespace Wipro.WebApi.DAL.Fila
{
    public class Conexao
    {

        private string stringConexao = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private SqlConnection _sqlConnection;

        public Conexao()
        {
            try
            {
                _sqlConnection = new SqlConnection(stringConexao);
                _sqlConnection.Open();
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
        }


        public void Close()
        {
            _sqlConnection.Close();
            _sqlConnection.Dispose();
        }


        //Executa Select
        public DataTable RetDatable(string sql)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(sql, _sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dataTable);

                //_sqlConnection.Close();
                //_sqlConnection.Dispose();

                return dataTable;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
                return null;
            }

        }


        //Executa Insert, Delete ou Update
        public string ExecutarComandoSQL(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();
                //_sqlConnection.Close();
                //_sqlConnection.Dispose();
                return "okay";
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
                return "erro - " + ex.Message;
            }

        }




    }
}
