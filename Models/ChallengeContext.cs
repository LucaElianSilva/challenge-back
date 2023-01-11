using System;
using System.Collections.Generic;
using challenge_back.Entities;
using Microsoft.EntityFrameworkCore;

namespace challenge_back.Models;

public partial class ChallengeContext : DbContext
{
    public ChallengeContext()
    {
    }

    public ChallengeContext(DbContextOptions<ChallengeContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=SHIFTA-0138\\SQLEXPRESS;Database=Challenge;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
