using App_Tarefas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App_Tarefas.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Tipo> Tipos { get; set; } = null!;

public DbSet<App_Tarefas.Models.Tarefa> Tarefa { get; set; } = default!;
}
