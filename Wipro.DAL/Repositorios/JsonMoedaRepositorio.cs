using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Wipro.WebApi.Model;

namespace Wipro.DAL.Repositorios
{
    public class JsonMoedaRepositorio : Interfaces.IJsonMoeda
    {
        
        private IDbConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        public void InserirDadosMoeda(DadosMoeda d)
        {           

            string sql = $"insert into DadosMoeda values ('{d.id_moeda}','{d.data_ref}')";

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {                
                conexao.Execute(sql);
            }
        }



        public void InserirDadosCotacao(DadosCotacao d)
        {

            string sql = $"insert into DadosCotacao values ('{d.vlr_cotacao}','{d.cod_cotacao}','{d.dat_cotacao}')";

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexao.Execute(sql);
            }
        }



        public List<DadosMoedaResultado> Resultado(string data_inicio, string data_fim)
        {
            string sql = "select ID_MOEDA,DATA_REF,vlr_cotacao from ( "+
                            "select DM.*,Mc.cod_cotacao " +
                            "from DadosMoeda DM " +
                            "inner join MoedaCotacao MC on DM.ID_MOEDA = MC.ID_MOEDA " +
                            ") tab " +
                            "inner join DadosCotacao DC on DC.cod_cotacao = tab.cod_cotacao and DC.dat_cotacao = tab.DATA_REF " +
                            $"where tab.DATA_REF >= '{data_inicio}' and tab.DATA_REF <= '{data_fim}'";

            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                return db.Query<DadosMoedaResultado>(sql).ToList();
            }

        }

        public void TruncarTabelas()
        {            
            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexao.Execute("truncate table DadosMoeda");
                conexao.Execute("truncate table DadosCotacao");

            }
        }



        public void BulkDadosMoeda(string path)
        {
            string query2 = "update DadosMoeda set DATA_REF = SUBSTRING(DATA_REF, 1, 10)";

            string query = $"BULK INSERT DadosMoeda from '{path}' "+
                            "with( "+
                                "FiRSTROW = 2," +
                                "FIELDTERMINATOR = ';'," +
                                "ROWTERMINATOR = '\n'" +
                            ")";


            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexao.Execute("truncate table DadosMoeda");
                conexao.Execute(query);
                conexao.Execute(query2);

            }
        }




        public void BulkDadosCotacao(string path)
        {


            string query = $"BULK INSERT DadosCotacao from '{path}' " +
                            "with( " +
                                "FiRSTROW = 2, " +
                                "FIELDTERMINATOR = ';', " +
                                "ROWTERMINATOR = '\n' " +
                            ")";

            string query2 = "update DadosCotacao set dat_cotacao = CONCAT ( SUBSTRING(dat_cotacao, 7, 4),'-', SUBSTRING(dat_cotacao, 4, 2), '-', SUBSTRING(dat_cotacao, 1, 2) )";


            using (SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conexao.Execute("truncate table DadosCotacao");
                conexao.Execute(query);
                conexao.Execute(query2);

            }
        }

       
    }
}
