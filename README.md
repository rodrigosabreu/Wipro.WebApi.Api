# Wipro.WebApi.Api
Rest Api

############# BD #############

Criar Base de Dados MSSQLLocalDB "Wipro" e rodar os scripts contidos no arquivo "script.sql"


############# WebAPI #############

Projeto: Wipro.WebApi.Api

Put de moedas para a fila

http://localhost:5000/fila/AddItemFila

Get útima moeda da fila

http://localhost:5000/fila/GetItemFila


############# Console #############

Projeto: Wipro.Cotacao

Url de geração dos arquivos: /Wipro.Cotacao

############# Depedencias #############

Wipro.DAL > Dapper 1.50.5

Wipro.WebApi.DAL.Fila > System.Data.SqlClient 4.8.2

#########################################################

Como executar aplicação:

1)Baixar o projeto no Github

2)Criar Base de Dados MSSQLLocalDB "Wipro" e rodar os scripts contidos no arquivo "script.sql"

3)Instalar Depencias caso necessário

4)Selecionar o projeto Wipro.WebApi.Api e executar (Ctrl+F5), e aparecerá um prompt de comando informando a url e porta

5)Colocar ar quivos csv´s de entrada no diretorio do projeto /Wipro.Console

6)Selecionar o projeto Wipro.Console e executar (Ctrl+F5), e aparecerá um prompt de comando informando a url e porta

7)Os aquivos de saida serão gerados no diretorio do projeto /Wipro.Console
