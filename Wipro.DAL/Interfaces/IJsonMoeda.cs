using System;
using System.Collections.Generic;
using System.Text;
using Wipro.WebApi.Model;

namespace Wipro.DAL.Interfaces
{
    public interface IJsonMoeda
    {
        void InserirDadosMoeda(DadosMoeda d);
        void InserirDadosCotacao(DadosCotacao d);
        void TruncarTabelas();
        void BulkDadosMoeda(string path);
        void BulkDadosCotacao(string path);
        


    }
}
