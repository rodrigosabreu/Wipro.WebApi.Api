using System;
using System.Collections.Generic;

namespace Wipro.WebApi.Model
{


    public class JsonMoeda
    {
        public int id { get; set; }
        public string moeda { get; set; }
        public string data_inicio { get; set; }
        public string data_fim { get; set; }

    }


    public class DadosMoeda
    {

        public string id_moeda { get; set; }
        public string data_ref { get; set; }        

    }


    public class DadosCotacao
    {
        public string vlr_cotacao { get; set; }
        public string cod_cotacao { get; set; }
        public string dat_cotacao { get; set; }

    }


    public class DadosMoedaResultado
    {

        public string ID_MOEDA { get; set; }
        public string DATA_REF { get; set; }
        public string vlr_cotacao { get; set; }

    }



















}
