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
            modelBuilder.Entity<Persona>().HasData(
                new Persona() { Id = 1, Nombre = "Luca", Apellido = "Silva", Edad = 22, Documento="42901989",  Sexo = (int)SexoEnum.Masculino },
                new Persona() { Id = 2, Nombre = "Emma", Apellido = "Watson", Edad = 27, Documento="4564546",  Sexo = (int)SexoEnum.Femenino },
                new Persona() { Id = 3, Nombre = "Ciro", Apellido = "Silva", Edad = 19, Documento="42901989",  Sexo = (int)SexoEnum.Masculino },
                new Persona() { Id = 4, Nombre = "Micaela", Apellido = "Anastacia", Edad = 18, Documento="4564233",  Sexo = (int)SexoEnum.Femenino }
            );
        }
    }
}
