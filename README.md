# Wipro.WebApi.Api
Rest Api

Criar Base de Dados MSSQLLocalDB Wipro e rodar os cripts abaixo como pré requisito de sistema

USE [Wipro]
GO

CREATE TABLE [dbo].[DadosCotacao] (
    [vlr_cotacao] VARCHAR (50) NULL,
    [cod_cotacao] VARCHAR (50) NULL,
    [dat_cotacao] VARCHAR (50) NULL
);

CREATE TABLE [dbo].[DadosMoeda] (
    [ID_MOEDA] VARCHAR (50) NULL,
    [DATA_REF] VARCHAR (50) NULL
);

CREATE TABLE [dbo].[fila] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [moeda]       VARCHAR (50) NULL,
    [data_inicio] VARCHAR (50) NULL,
    [data_fim]    VARCHAR (50) NULL
);

CREATE TABLE [dbo].[MoedaCotacao] (
    [ID_MOEDA]    VARCHAR (50) NULL,
    [cod_cotacao] VARCHAR (50) NULL
);

insert into cotacao values ('AFN','66')
insert into cotacao values ('ALL','49')
insert into cotacao values ('ANG','33')
insert into cotacao values ('ARS','3')
insert into cotacao values ('AWG','6')
insert into cotacao values ('BOB','56')
insert into cotacao values ('BYN','64')
insert into cotacao values ('CAD','25')
insert into cotacao values ('CDF','58')
insert into cotacao values ('CLP','16')
insert into cotacao values ('COP','37')
insert into cotacao values ('CRC','52')
insert into cotacao values ('CUP','8')
insert into cotacao values ('CVE','51')
insert into cotacao values ('CZK','29')
insert into cotacao values ('DJF','36')
insert into cotacao values ('DZD','54')
insert into cotacao values ('EGP','12')
insert into cotacao values ('EUR','20')
insert into cotacao values ('FJD','38')
insert into cotacao values ('GBP','22')
insert into cotacao values ('GEL','48')
insert into cotacao values ('GIP','18')
insert into cotacao values ('HTG','63')
insert into cotacao values ('ILS','40')
insert into cotacao values ('IRR','17')
insert into cotacao values ('ISK','11')
insert into cotacao values ('JPY','9')
insert into cotacao values ('KES','21')
insert into cotacao values ('KMF','19')
insert into cotacao values ('LBP','42')
insert into cotacao values ('LSL','4')
insert into cotacao values ('MGA','35')
insert into cotacao values ('MGB','26')
insert into cotacao values ('MMK','69')
insert into cotacao values ('MRO','53')
insert into cotacao values ('MRU','15')
insert into cotacao values ('MUR','7')
insert into cotacao values ('MXN','41')
insert into cotacao values ('MZN','43')
insert into cotacao values ('NIO','23')
insert into cotacao values ('NOK','62')
insert into cotacao values ('OMR','34')
insert into cotacao values ('PEN','45')
insert into cotacao values ('PGK','2')
insert into cotacao values ('PHP','24')
insert into cotacao values ('RON','5')
insert into cotacao values ('SAR','44')
insert into cotacao values ('SBD','32')
insert into cotacao values ('SGD','70')
insert into cotacao values ('SLL','10')
insert into cotacao values ('SOS','61')
insert into cotacao values ('SSP','47')
insert into cotacao values ('SZL','55')
insert into cotacao values ('THB','39')
insert into cotacao values ('TRY','13')
insert into cotacao values ('TTD','67')
insert into cotacao values ('UGX','59')
insert into cotacao values ('USD','1')
insert into cotacao values ('UYU','46')
insert into cotacao values ('VES','68')
insert into cotacao values ('VUV','57')
insert into cotacao values ('WST','28')
insert into cotacao values ('XAF','30')
insert into cotacao values ('XAU','60')
insert into cotacao values ('XDR','27')
insert into cotacao values ('XOF','14')
insert into cotacao values ('XPF','50')
insert into cotacao values ('ZAR','65')
insert into cotacao values ('ZWL','31')
