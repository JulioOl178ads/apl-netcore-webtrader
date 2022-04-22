﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using WebTrader.Context;

#nullable disable

namespace WebTrader.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220422021243_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebTrader.Models.Dominio.T_Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasMaxLength(1)
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("NVARCHAR2(2)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("NumeroCasa")
                        .HasMaxLength(5)
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("País")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("IdEndereco");

                    b.ToTable("T_Endereco");
                });

            modelBuilder.Entity("WebTrader.Models.T_Contato", b =>
                {
                    b.Property<int>("IdContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContato"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("DescricaoContato")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.Property<int?>("T_Tipo_EnderecoIdEndereco")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("TipoContatoIdContato")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IdContato");

                    b.HasIndex("T_Tipo_EnderecoIdEndereco");

                    b.HasIndex("TipoContatoIdContato");

                    b.ToTable("T_Contato");
                });

            modelBuilder.Entity("WebTrader.Models.T_Proposta_Negociacao", b =>
                {
                    b.Property<int>("IdPropostaNegociacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPropostaNegociacao"), 1L, 1);

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Empresa")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("ImagemThumbnailUrl")
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Marca")
                        .HasMaxLength(25)
                        .HasColumnType("NVARCHAR2(25)");

                    b.Property<string>("PermiteUsado")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("NVARCHAR2(3)");

                    b.Property<decimal>("Preco")
                        .HasMaxLength(25)
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(5)
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("TipoProdutoIdTipoProduto")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("IdPropostaNegociacao");

                    b.HasIndex("TipoProdutoIdTipoProduto");

                    b.HasIndex("UsuarioId");

                    b.ToTable("T_Proposta_Negociacao");
                });

            modelBuilder.Entity("WebTrader.Models.T_Tipo_Contato", b =>
                {
                    b.Property<int>("IdContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContato"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("IdContato");

                    b.ToTable("T_Tipo_Contato");
                });

            modelBuilder.Entity("WebTrader.Models.T_Tipo_Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("IdEndereco");

                    b.ToTable("T_Tipo_Endereco");
                });

            modelBuilder.Entity("WebTrader.Models.T_Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<int?>("ContatosIdContato")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("EnderecosIdEndereco")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("Id");

                    b.HasIndex("ContatosIdContato");

                    b.HasIndex("EnderecosIdEndereco");

                    b.ToTable("T_Usuario");
                });

            modelBuilder.Entity("WebTrader.Models.Tipo.T_Tipo_Produto", b =>
                {
                    b.Property<int>("IdTipoProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoProduto"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.HasKey("IdTipoProduto");

                    b.ToTable("T_Tipo_Produto");
                });

            modelBuilder.Entity("WebTrader.Models.T_Contato", b =>
                {
                    b.HasOne("WebTrader.Models.T_Tipo_Endereco", null)
                        .WithMany("Contatos")
                        .HasForeignKey("T_Tipo_EnderecoIdEndereco");

                    b.HasOne("WebTrader.Models.T_Tipo_Contato", "TipoContato")
                        .WithMany("Contatos")
                        .HasForeignKey("TipoContatoIdContato");

                    b.Navigation("TipoContato");
                });

            modelBuilder.Entity("WebTrader.Models.T_Proposta_Negociacao", b =>
                {
                    b.HasOne("WebTrader.Models.Tipo.T_Tipo_Produto", "TipoProduto")
                        .WithMany("TiposProduto")
                        .HasForeignKey("TipoProdutoIdTipoProduto");

                    b.HasOne("WebTrader.Models.T_Usuario", "Usuario")
                        .WithMany("Propostas")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("TipoProduto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebTrader.Models.T_Usuario", b =>
                {
                    b.HasOne("WebTrader.Models.T_Contato", "Contatos")
                        .WithMany("Usuario")
                        .HasForeignKey("ContatosIdContato");

                    b.HasOne("WebTrader.Models.Dominio.T_Endereco", "Enderecos")
                        .WithMany("Usuario")
                        .HasForeignKey("EnderecosIdEndereco");

                    b.Navigation("Contatos");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("WebTrader.Models.Dominio.T_Endereco", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebTrader.Models.T_Contato", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebTrader.Models.T_Tipo_Contato", b =>
                {
                    b.Navigation("Contatos");
                });

            modelBuilder.Entity("WebTrader.Models.T_Tipo_Endereco", b =>
                {
                    b.Navigation("Contatos");
                });

            modelBuilder.Entity("WebTrader.Models.T_Usuario", b =>
                {
                    b.Navigation("Propostas");
                });

            modelBuilder.Entity("WebTrader.Models.Tipo.T_Tipo_Produto", b =>
                {
                    b.Navigation("TiposProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
