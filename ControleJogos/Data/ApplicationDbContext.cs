using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ControleJogos.Models;

namespace ControleJogos.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Amigo> Amigo { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Amigo            
            builder.Entity<Amigo>()
                .HasKey(p => new { p.Id });
            builder.Entity<Amigo>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasColumnName("Id");
            builder.Entity<Amigo>()
                .Property(p => p.Nome)
                .HasColumnType("Varchar(50)")
                .HasColumnName("Nome");
            builder.Entity<Amigo>()
                .Property(p => p.Telefone)
                .HasColumnType("Varchar(50)")
                .HasColumnName("Telefone");
            builder.Entity<Amigo>()
               .Property(p => p.Email)
               .HasColumnType("Varchar(50)")
               .HasColumnName("Email");
            #endregion
            #region Jogo            
            builder.Entity<Jogo>()
                .HasKey(p => new { p.Id });
            builder.Entity<Jogo>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasColumnName("Id");
            builder.Entity<Jogo>()
                .Property(p => p.Nome)
                .HasColumnType("Varchar(50)")
                .HasColumnName("Nome");
            builder.Entity<Jogo>()
                .Property(p => p.Tipo)
                .HasColumnType("Varchar(50)")
                .HasColumnName("Tipo");
            #endregion
            #region Emprestimo            
            builder.Entity<Emprestimo>()
                .HasKey(p => new { p.Id });
            builder.Entity<Emprestimo>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasColumnName("Id");
            builder.Entity<Emprestimo>()
                .Property(p => p.Quantidade)
                .HasColumnType("int")
                .HasColumnName("Quantidade");
            #endregion
            #region Relacionamento
            builder.Entity<Emprestimo>()
                .HasOne(e => e.Amogo)
                .WithMany(e => e.Emprestimos);
            builder.Entity<Emprestimo>()
               .HasOne(e => e.Jogo)
               .WithMany(e => e.Emprestimos);
            #endregion

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
