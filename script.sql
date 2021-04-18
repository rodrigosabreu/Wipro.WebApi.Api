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

insert into MoedaCotacao values ('AFN','66')
insert into MoedaCotacao values ('ALL','49')
insert into MoedaCotacao values ('ANG','33')
insert into MoedaCotacao values ('ARS','3')
insert into MoedaCotacao values ('AWG','6')
insert into MoedaCotacao values ('BOB','56')
insert into MoedaCotacao values ('BYN','64')
insert into MoedaCotacao values ('CAD','25')
insert into MoedaCotacao values ('CDF','58')
insert into MoedaCotacao values ('CLP','16')
insert into MoedaCotacao values ('COP','37')
insert into MoedaCotacao values ('CRC','52')
insert into MoedaCotacao values ('CUP','8')
insert into MoedaCotacao values ('CVE','51')
insert into MoedaCotacao values ('CZK','29')
insert into MoedaCotacao values ('DJF','36')
insert into MoedaCotacao values ('DZD','54')
insert into MoedaCotacao values ('EGP','12')
insert into MoedaCotacao values ('EUR','20')
insert into MoedaCotacao values ('FJD','38')
insert into MoedaCotacao values ('GBP','22')
insert into MoedaCotacao values ('GEL','48')
insert into MoedaCotacao values ('GIP','18')
insert into MoedaCotacao values ('HTG','63')
insert into MoedaCotacao values ('ILS','40')
insert into MoedaCotacao values ('IRR','17')
insert into MoedaCotacao values ('ISK','11')
insert into MoedaCotacao values ('JPY','9')
insert into MoedaCotacao values ('KES','21')
insert into MoedaCotacao values ('KMF','19')
insert into MoedaCotacao values ('LBP','42')
insert into MoedaCotacao values ('LSL','4')
insert into MoedaCotacao values ('MGA','35')
insert into MoedaCotacao values ('MGB','26')
insert into MoedaCotacao values ('MMK','69')
insert into MoedaCotacao values ('MRO','53')
insert into MoedaCotacao values ('MRU','15')
insert into MoedaCotacao values ('MUR','7')
insert into MoedaCotacao values ('MXN','41')
insert into MoedaCotacao values ('MZN','43')
insert into MoedaCotacao values ('NIO','23')
insert into MoedaCotacao values ('NOK','62')
insert into MoedaCotacao values ('OMR','34')
insert into MoedaCotacao values ('PEN','45')
insert into MoedaCotacao values ('PGK','2')
insert into MoedaCotacao values ('PHP','24')
insert into MoedaCotacao values ('RON','5')
insert into MoedaCotacao values ('SAR','44')
insert into MoedaCotacao values ('SBD','32')
insert into MoedaCotacao values ('SGD','70')
insert into MoedaCotacao values ('SLL','10')
insert into MoedaCotacao values ('SOS','61')
insert into MoedaCotacao values ('SSP','47')
insert into MoedaCotacao values ('SZL','55')
insert into MoedaCotacao values ('THB','39')
insert into MoedaCotacao values ('TRY','13')
insert into MoedaCotacao values ('TTD','67')
insert into MoedaCotacao values ('UGX','59')
insert into MoedaCotacao values ('USD','1')
insert into MoedaCotacao values ('UYU','46')
insert into MoedaCotacao values ('VES','68')
insert into MoedaCotacao values ('VUV','57')
insert into MoedaCotacao values ('WST','28')
insert into MoedaCotacao values ('XAF','30')
insert into MoedaCotacao values ('XAU','60')
insert into MoedaCotacao values ('XDR','27')
insert into MoedaCotacao values ('XOF','14')
insert into MoedaCotacao values ('XPF','50')
insert into MoedaCotacao values ('ZAR','65')
insert into MoedaCotacao values ('ZWL','31')
