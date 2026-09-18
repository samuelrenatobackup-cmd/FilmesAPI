using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filmes => Set<Filme>();
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Diretor> Diretores => Set<Diretor>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Diretor 1:N Filmes
            modelBuilder.Entity<Diretor>()
                .HasMany(d => d.Filmes)
                .WithOne(f => f.Diretor)
                .HasForeignKey(f => f.IdDiretor);

            // Filme N:N Genero
            modelBuilder.Entity<Filme>()
                .HasMany(f => f.Generos)
                .WithMany(g => g.Filmes);

        }
    }
}