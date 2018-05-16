 
IF DB_ID('WeatherAPI') IS NULL 
  BEGIN 

	  /** 
	   * Cria��o da base da dados 
	   */
      CREATE DATABASE [WeatherAPI] 
  END 
GO

IF Object_id(N'WeatherAPI.dbo.Cidades', N'U') IS NULL 
  BEGIN 
   
      /** 
       * Defini��o de qual banco de dados usar 
       */ 
      USE [WeatherAPI] 

      /** 
       * Cria��o da tabela Cidades 
       */ 
      CREATE TABLE [dbo].[Cidades] 
      ( 
           [CidadeId] [INT] IDENTITY(1, 1) NOT NULL, 
           [Nome]     [VARCHAR](20)        NOT NULL 
           CONSTRAINT [PK_Cidades_CidadeId] PRIMARY KEY CLUSTERED ([CidadeId] ASC) 
      ) 

      /** 
        * Defini��o/Documenta��o do Dicion�rio de Dados:  
        * Descri��o das informa��es da Tabela Cidades e dos Campos da Tabela Cidades.
        */ 
      EXEC sys.Sp_addextendedproperty 
        @name=N'Descri��o', 
        @value= N'Tabela que guarda as cidades cadastradas pelo sistema WeatherAPI', 
        @level0type=N'SCHEMA', 
        @level0name=N'dbo', 
        @level1type=N'TABLE', 
        @level1name=N'Cidades' 

      EXEC sys.Sp_addextendedproperty 
        @name=N'Descri��o', 
        @value=N'Coluna de identifica��o (identidade) desta tabela', 
        @level0type=N'SCHEMA', 
        @level0name=N'dbo', 
        @level1type=N'TABLE', 
        @level1name=N'Cidades', 
        @level2type=N'COLUMN', 
        @level2name=N'CidadeId' 

      EXEC sys.Sp_addextendedproperty 
        @name=N'Descri��o', 
        @value=N'Coluna respons�vel por guardar os nomes das cidades.', 
        @level0type=N'SCHEMA', 
        @level0name=N'dbo', 
        @level1type=N'TABLE', 
        @level1name=N'Cidades', 
        @level2type=N'COLUMN', 
        @level2name=N'Nome' 
  END 
GO
