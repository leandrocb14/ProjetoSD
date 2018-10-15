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

        private string StringConnectionSqlServer = string.Format(@"Server=DESKTOP-R3HGIEK;Database=ProjetoSD;User Id=sa;
Password=@Leandro123;");

        public DbSet<Usuario> Usuarios { get; set; }

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
        }
    }
}