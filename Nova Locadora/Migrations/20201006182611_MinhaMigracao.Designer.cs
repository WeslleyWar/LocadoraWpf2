﻿// <auto-generated />
using System;
using Locadora.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201006182611_MinhaMigracao")]
    partial class MinhaMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locadora.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Locadora.Model.Devolucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DevolucaoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<double>("ValorMulta")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Devolucoes");
                });

            modelBuilder.Entity("Locadora.Model.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContatoPessoal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermissãoDirigir")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Locadora.Model.ItemLocacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("QntdDias")
                        .HasColumnType("int");

                    b.Property<double>("ValorDia")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("ItemLoc");
                });

            modelBuilder.Entity("Locadora.Model.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DevolucaoPrevista")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LocadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("QntdDiasAtraso")
                        .HasColumnType("int");

                    b.Property<int>("QntdDiasLocacao")
                        .HasColumnType("int");

                    b.Property<double>("ValorComMulta")
                        .HasColumnType("float");

                    b.Property<double>("ValorSemMulta")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Locadora.Model.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeMarca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeModelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Potencia")
                        .HasColumnType("int");

                    b.Property<int>("QntdPortas")
                        .HasColumnType("int");

                    b.Property<int>("Renavan")
                        .HasColumnType("int");

                    b.Property<string>("StatusVeiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCombustivel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoVeiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorDia")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Locadora.Model.Devolucao", b =>
                {
                    b.HasOne("Locadora.Model.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Locadora.Model.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("Locadora.Model.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("Locadora.Model.ItemLocacao", b =>
                {
                    b.HasOne("Locadora.Model.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("Locadora.Model.Locacao", b =>
                {
                    b.HasOne("Locadora.Model.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Locadora.Model.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("Locadora.Model.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}