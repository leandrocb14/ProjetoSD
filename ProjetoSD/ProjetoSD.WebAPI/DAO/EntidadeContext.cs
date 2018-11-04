﻿using Microsoft.EntityFrameworkCore;
using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.DAO
{
    public class EntidadeContext : DbContext
    {

        private string StringConnectionSqlServer = string.Format(@"Server=DESKTOP-OH0QV0R;Database=ProjetoSD;User Id=sa;
Password=@Leandro123;");

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StringConnectionSqlServer);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Usuario - TUSU
            modelBuilder.Entity<Usuario>().ToTable("TUSU");

            modelBuilder.Entity<Usuario>(u =>
            {
                u.Property(cu => cu.Id).HasColumnName("CUSUID");

                u.Property(cu => cu.Email).HasColumnName("CUSUEMAIL");
                u.Property(cu => cu.Email).HasColumnType("VARCHAR(60)");
                u.Property(cu => cu.Email).IsRequired();

                u.Property(cu => cu.Senha).HasColumnName("CUSUSENHA");
                u.Property(cu => cu.Senha).HasColumnType("VARCHAR(25)");
                u.Property(cu => cu.Senha).IsRequired();

                u.Property(cu => cu.TipoStatus).HasColumnName("CUSUTIPOSTATUS");
                u.Property(cu => cu.TipoStatus).HasConversion(cu => cu.ToString(), cu => (TipoStatus)Enum.Parse(typeof(TipoStatus), cu));
                u.Property(cu => cu.TipoStatus).HasDefaultValue(TipoStatus.S);

                u.HasIndex(cu => cu.Email).IsUnique();
            });
            #endregion

            #region Medico - TMEDIC
            modelBuilder.Entity<Medico>().ToTable("TMED");

            modelBuilder.Entity<Medico>(m =>
            {
                m.Property(cm => cm.Id).HasColumnName("CMEDID");

                m.Property(cm => cm.CRM).HasColumnName("CMEDCRM");
                m.Property(cm => cm.CRM).HasColumnType("VARCHAR(10)");
                m.Property(cm => cm.CRM).IsRequired();

                m.Property(cm => cm.Nome).HasColumnName("CMEDNOME");
                m.Property(cm => cm.Nome).HasColumnType("VARCHAR(90)");
                m.Property(cm => cm.Nome).IsRequired();

                m.Property(cm => cm.UF).HasColumnName("CMEDUF");
                m.Property(cm => cm.UF).HasConversion(cm => cm.ToString(), cm => (UF)Enum.Parse(typeof(UF), cm));
                m.Property(cm => cm.UF).IsRequired();

                m.Property(cm => cm.Profissao).HasColumnName("CMEDPROFISSAO");
                m.Property(cm => cm.Profissao).HasColumnType("VARCHAR(90)");

                m.Property(cm => cm.UsuarioId).HasColumnName("CMEDUSUID");
                m.HasOne(cm => cm.Usuario).WithOne(u => u.Medico).HasForeignKey<Medico>(cm => cm.UsuarioId);
                
                m.HasIndex(cm => cm.CRM).IsUnique();
            });            
            #endregion
        }
    }
}