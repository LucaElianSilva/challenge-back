using System;
using System.Collections.Generic;
using challenge_back.Entities;
using Microsoft.EntityFrameworkCore;

namespace challenge_back.Models;

public partial class ChallengeContext : DbContext
{
    public IConfiguration Configuration;
    public ChallengeContext(DbContextOptions<ChallengeContext> options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
    }

    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
