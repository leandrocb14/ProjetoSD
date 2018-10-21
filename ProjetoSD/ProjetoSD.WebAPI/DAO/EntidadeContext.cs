using Microsoft.EntityFrameworkCore;
using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.DAO
{
    public class EntidadeContext : DbContext
    {

        private string StringConnectionSqlServer = string.Format(@"Server=DESKTOP-FORDN6B;Database=ProjetoSD;User Id=sa;
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

            modelBuilder.Entity<Usuario>().Property(u => u.Id).HasColumnName("CUSUID");

            modelBuilder.Entity<Usuario>().Property(u => u.Email).HasColumnName("CUSUEMAIL");
            modelBuilder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(60);
            modelBuilder.Entity<Usuario>().Property(u => u.Email).IsRequired();

            modelBuilder.Entity<Usuario>().Property(u => u.Senha).HasColumnName("CUSUSENHA");
            modelBuilder.Entity<Usuario>().Property(u => u.Senha).HasMaxLength(25);
            modelBuilder.Entity<Usuario>().Property(u => u.Senha).IsRequired();

            modelBuilder.Entity<Usuario>().Property(u => u.TipoStatus).HasColumnName("CUSUTIPOSTATUS");
            modelBuilder.Entity<Usuario>().Property(u => u.TipoStatus).HasConversion(u => u.ToString(), u => (TipoStatus)Enum.Parse(typeof(TipoStatus), u));
            modelBuilder.Entity<Usuario>().Property(u => u.TipoStatus).HasDefaultValue(TipoStatus.S);
            #endregion

            #region Medico - TMEDIC
            modelBuilder.Entity<Medico>().ToTable("TMED");

            modelBuilder.Entity<Medico>().Property(m => m.Id).HasColumnName("CMEDCRM");
            modelBuilder.Entity<Medico>().Property(m => m.Id).ValueGeneratedNever();
            modelBuilder.Entity<Medico>().HasIndex(m => m.Id).IsUnique();
            

            modelBuilder.Entity<Medico>().Property(m => m.Nome).HasColumnName("CMEDNOME");
            modelBuilder.Entity<Medico>().Property(m => m.Nome).HasMaxLength(90);
            modelBuilder.Entity<Medico>().Property(m => m.Nome).IsRequired();

            modelBuilder.Entity<Medico>().Property(m => m.UF).HasColumnName("CMEDUF");
            modelBuilder.Entity<Medico>().Property(m => m.UF).HasConversion(m => m.ToString(), m => (UF)Enum.Parse(typeof(UF), m));
            modelBuilder.Entity<Medico>().Property(m => m.UF).IsRequired();
            
            modelBuilder.Entity<Medico>().Property(m => m.Profissao).HasColumnName("CMEDPROFISSAO");
            modelBuilder.Entity<Medico>().Property(m => m.Profissao).HasMaxLength(90);
            #endregion
        }
    }
}