using Clarify.Models;
using Microsoft.EntityFrameworkCore;

namespace Clarify.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Conta>? Contas { get; set; }
    
    public DbSet<Grupo>? Grupos { get; set; }
    
    public DbSet<Lancamento>? Lancamentos { get; set; }
    
    public DbSet<Partida>? Partidas { get; set; }
}