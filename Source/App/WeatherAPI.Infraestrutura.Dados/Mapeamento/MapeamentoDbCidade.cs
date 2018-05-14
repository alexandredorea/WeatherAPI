using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WeatherAPI.Dominio.Entidades;

namespace WeatherAPI.Infraestrutura.Dados.Mapeamento
{
    /// <summary>
    /// Classe de mapeamento Específico ta tabela de Cidade no Banco de Dados
    /// </summary>
    public class MapeamentoDbCidade : IEntityTypeConfiguration<Cidade>
    {
        /// <summary>
        /// Configuração da Tabela
        /// </summary>
        /// <param name="construtor"></param>
        public void Configure(EntityTypeBuilder<Cidade> construtor)
        {
            //Nome da tabela
            construtor.ToTable("Cidades");

            //Definição da chave primaria, índices e os respectivos nomes
            construtor.HasKey(m => m.Id)
                .HasName("PK_Cidades_CidadeId")
                .ForSqlServerIsClustered();

            construtor.HasIndex(m => m.Id)
                .HasName("IX_Cidades_CidadeId")
                .IsUnique();

            //Definição das propriedades no banco de dados
            construtor.Property(m => m.Id)
                .HasColumnName("CidadeId")
                .UseSqlServerIdentityColumn()
                .ValueGeneratedOnAdd();

            construtor.Property(m => m.Nome)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
