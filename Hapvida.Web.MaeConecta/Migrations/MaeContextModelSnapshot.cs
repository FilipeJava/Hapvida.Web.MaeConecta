﻿// <auto-generated />
using System;
using Hapvida.Web.MaeConecta.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hapvida.Web.MaeConecta.Migrations
{
    [DbContext(typeof(MaeContext))]
    partial class MaeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Contatos", b =>
                {
                    b.Property<int>("ContatosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContatosId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relacionamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ContatosId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tbl_contato");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Tbl_Endereco");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Ocorrencias", b =>
                {
                    b.Property<int>("OcorrenciasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OcorrenciasId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_ocorrencia");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("OcorrenciasId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tbl_ocorrencia");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Procedimentos", b =>
                {
                    b.Property<int>("ProcedimentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcedimentosId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_procedimento");

                    b.Property<int>("Especialidade")
                        .HasColumnType("int")
                        .HasColumnName("Ds_especialidade");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("Ds_tipo");

                    b.HasKey("ProcedimentosId");

                    b.ToTable("Tbl_procedimento");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Cadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SemanaGestacao")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoSanguineo")
                        .HasColumnType("int")
                        .HasColumnName("Tp_Sangue");

                    b.HasKey("UsuarioId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Tbl_usuario");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Contatos", b =>
                {
                    b.HasOne("Hapvida.Web.MaeConecta.Models.Usuario", null)
                        .WithMany("Contatos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Ocorrencias", b =>
                {
                    b.HasOne("Hapvida.Web.MaeConecta.Models.Usuario", null)
                        .WithMany("Ocorrencias")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Usuario", b =>
                {
                    b.HasOne("Hapvida.Web.MaeConecta.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Hapvida.Web.MaeConecta.Models.Usuario", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("Ocorrencias");
                });
#pragma warning restore 612, 618
        }
    }
}
