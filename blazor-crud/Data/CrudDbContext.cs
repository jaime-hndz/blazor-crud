using Microsoft.EntityFrameworkCore;

namespace blazor_crud.Data;

internal sealed class CrudDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=DbDealer.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Post[] postsToSeed = new Post[6];

        for (int i = 1; i <= 6; i++)
        {
            postsToSeed[i - 1] = new Post
            {
                Id = i,
                Chasis = $"Chasis {i}",
                Marca = $"Marca {i}",
                Modelo = $"Modelo {i}",
                Color = $"Color {i}",
                Year = $"Year {i}",
                Comentario = $"Comentario {i}",
                Foto = $"Foto {i}",
            };
        }

        modelBuilder.Entity<Post>().HasData(postsToSeed);

    }

}

