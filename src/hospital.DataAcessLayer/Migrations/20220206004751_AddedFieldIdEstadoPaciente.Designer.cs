// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hospital.DataAcessLayer.ORM;

#nullable disable

namespace hospital.DataAcessLayer.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20220206004751_AddedFieldIdEstadoPaciente")]
    partial class AddedFieldIdEstadoPaciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("hospital.Domain.Entities.Mural", b =>
                {
                    b.Property<long>("Mural_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Mural_Id"), 1L, 1);

                    b.Property<string>("Mural_Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mural_Aviso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Mural_Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mural_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mural_Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mural_Id");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("hospital.Domain.Models.EstadoPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("EstadoPaciente");
                });

            modelBuilder.Entity("hospital.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInternacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EstadoPacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RgDataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("RgOrgao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<int>("TipoPaciente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoPacienteId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("hospital.Domain.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<string>("IdentityID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("ProductName")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("hospital.Domain.Models.Paciente", b =>
                {
                    b.HasOne("hospital.Domain.Models.EstadoPaciente", "EstadoPaciente")
                        .WithMany()
                        .HasForeignKey("EstadoPacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoPaciente");
                });
#pragma warning restore 612, 618
        }
    }
}
