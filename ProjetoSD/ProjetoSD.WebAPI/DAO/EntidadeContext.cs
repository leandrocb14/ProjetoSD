using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StringConnectionSqlServer);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}