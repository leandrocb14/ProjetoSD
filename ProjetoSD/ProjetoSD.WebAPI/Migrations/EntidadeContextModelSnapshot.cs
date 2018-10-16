﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoSD.WebAPI.DAO;
using ProjetoSD.WebAPI.Models;

namespace ProjetoSD.WebAPI.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    partial class EntidadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoSD.WebAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CUSUID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("CUSUEMAIL")
                        .HasMaxLength(60);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("CUSUSENHA")
                        .HasMaxLength(25);

                    b.Property<string>("TipoStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CUSUTIPOSTATUS")
                        .HasDefaultValue("S");

                    b.HasKey("Id");

                    b.ToTable("TUSU");
                });
#pragma warning restore 612, 618
        }
    }
}