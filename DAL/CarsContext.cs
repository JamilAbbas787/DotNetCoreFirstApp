using System;
using Microsoft.EntityFrameworkCore;
using DotNetCoreFirstApp.Models;

namespace NamespaceName
{

public class Context : DbContext
{

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Cars> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     optionsBuilder.UseSqlServer(@"Server=.\;Database=Cars;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
  }
}