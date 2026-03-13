using GestaoEventos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoEventos.Data;

public class ApplicationDbContext : IdentityDbContext
{
    //Passo 2: Após criar a model, declarar ela no Context
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    // Aqui nós declaramos a model que voce acabou de criar!
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Local> Locais { get; set; }

    //Passo 3
    // Criar a migration que sera responsavel por 
    // fazer uma estrutura em SQL baseada nas models
    //Comandos:
    // 1. add-migration AddCategorias
    // 2. Update-database

    // Onde:
    //Ferramentas -> gerenciador pacotes -> Console
}
