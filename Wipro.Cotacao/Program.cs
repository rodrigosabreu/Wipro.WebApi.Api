using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Wipro.WebApi.Model;

namespace Wipro.Cotacao
{
    class Program
    {

        public static DAL.Repositorios.JsonMoedaRepositorio p = new DAL.Repositorios.JsonMoedaRepositorio();

        public static async Task<string> getMoeda()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"http://localhost:5000/fila/GetItemFila");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }

        
        static void Main(string[] args)
        {
            while (true)
            {
                Task task1 = Task.Factory.StartNew(() => LerArquivos()); //cria thered para chamar a funcao 
                Task.WaitAll(task1);//espera a thead acabar
                Task.Delay(10000).Wait(); // apois 10 seg faz denovo

            }        

        }








        static void LerArquivos()
        {
            DateTime dateTime = DateTime.Now;          
            
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;            

            string pathDadosMoeda = projectDirectory + @"\DadosMoeda.csv";
            string pathDadosCotacao = projectDirectory + @"\DadosCotacao.csv";
            string pathDadosResposta = projectDirectory + @"\Resultado_"+ dateTime.ToString("yyyyMMdd_HHmmss") + ".csv";

            var jsonString = "";
            try
            {
                jsonString = getMoeda().Result;
            }
            catch(Exception e)
            {
                Console.WriteLine("Não foi possivel comunicar com a API");
                Console.WriteLine("Execute o projeto da API");                
            }

            if (!String.IsNullOrEmpty(jsonString))
            {
                             
                         


                dynamic DynamicData = JsonConvert.DeserializeObject(jsonString);

                string moeda = DynamicData.moeda;
                string data_inicio = DynamicData.data_inicio;
                string data_fim = DynamicData.data_fim;

                //string moeda = "EUR";
                //string data_inicio = "2010-12-01";
                //string data_fim = "2020-01-01";


                if (String.IsNullOrEmpty(moeda))
                {
                    Console.WriteLine("API esta com fila zerada");
                    Console.WriteLine("Popule API com Postman");
                }
                else
                {

                    p.BulkDadosMoeda(pathDadosMoeda);
                    Console.WriteLine("Importado Dados Moeda");


                    p.BulkDadosCotacao(pathDadosCotacao);
                    Console.WriteLine("Importado Dados Cotação");


                    int count = 1;

                    Stopwatch tempo = new Stopwatch();
                    tempo.Start();

                   
                    
                    var resultado = p.Resultado(data_inicio, data_fim);

                    List<string> outLines = new List<string>();

                    
                    foreach (DadosMoedaResultado f in resultado)
                    {


                        if (count == 1)
                        {
                            outLines.Add("ID_MOEDA;DATA_REF;vlr_cotacao");
                        }

                        outLines.Add(f.ID_MOEDA + ";" +
                            f.DATA_REF + ";" +
                            f.vlr_cotacao);
                        Console.WriteLine(count + " - RESULTADO #################################");
                        count++;
                    }

                    System.IO.File.WriteAllLines(pathDadosResposta, outLines.ToArray());




                    tempo.Stop();
                    Console.WriteLine("Tempo: " + tempo.Elapsed);
                    Console.WriteLine(count + " - Terminou");
                }
            }
            
        }




    }
}
