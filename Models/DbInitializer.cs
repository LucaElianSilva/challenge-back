using challenge_back.Entities;
using challenge_back.Enums;
using Microsoft.EntityFrameworkCore;

namespace challenge_back.Models
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto() { Id = 1, Nombre = "Prod 1", Precio = 5, FechaCarga = DateTime.Now, Categoria = (int)CategoriaEnum.PRODDOS },
                new Producto() { Id = 2, Nombre = "Prod 2", Precio = 10, FechaCarga = DateTime.Now, Categoria = (int)CategoriaEnum.PRODUNO },
                new Producto() { Id = 3, Nombre = "Prod 3", Precio = 15, FechaCarga = DateTime.Now, Categoria = (int)CategoriaEnum.PRODDOS },
                new Producto() { Id = 4, Nombre = "Prod 4", Precio = 20, FechaCarga = DateTime.Now, Categoria = (int)CategoriaEnum.PRODUNO },
                new Producto() { Id = 5, Nombre = "Prod 5", Precio = 25, FechaCarga = DateTime.Now, Categoria = (int)CategoriaEnum.PRODDOS }
            );
        }
    }
}
