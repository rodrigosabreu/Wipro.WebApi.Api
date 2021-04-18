using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Wipro.WebApi.Model;

namespace Wipro.WebApi.DAL.Fila
{
    public class MoedaDAL
    {
        JsonMoeda _jsonMoeda = new JsonMoeda();
        Conexao _conexao = new Conexao();

        public void AddItemFila(List<JsonMoeda> jsonMoeda)
        {

            foreach(JsonMoeda json in jsonMoeda)
            {
                string query = $"insert into fila values ('{json.moeda}', '{json.data_inicio}', '{json.data_fim}')";
                _conexao.ExecutarComandoSQL(query);
            }

            _conexao.Close();

        }


        public string getIdCotacao(string moeda)
        {
            string query = $"select top 1 cod_cotacao from cotacao where ID_MOEDA = '{moeda}'";
            DataTable dt = _conexao.RetDatable(query);
            return dt.Rows[0]["cod_cotacao"].ToString();
        }


        public JsonMoeda GetUltimoItemFila()
        {
            string query = $"select top 1 * from fila order by id desc";
            DataTable dt = _conexao.RetDatable(query);

            if(dt.Rows.Count > 0)
            {
                _jsonMoeda.id = Convert.ToInt32(dt.Rows[0]["id"]);
                _jsonMoeda.moeda = dt.Rows[0]["moeda"].ToString();
                _jsonMoeda.data_inicio = dt.Rows[0]["data_inicio"].ToString();
                _jsonMoeda.data_fim = dt.Rows[0]["data_fim"].ToString();


                string query2 = $"delete from fila where id = {_jsonMoeda.id}";
                _conexao.ExecutarComandoSQL(query2);

                _conexao.Close();
            }
            else
            {
                _jsonMoeda.id = 0;
                _jsonMoeda.moeda = null;
                _jsonMoeda.data_inicio = null;
                _jsonMoeda.data_fim = null;
            }                      

            return _jsonMoeda;
        }


    }
}
