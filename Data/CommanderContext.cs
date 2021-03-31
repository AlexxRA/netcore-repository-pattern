using Microsoft.EntityFrameworkCore;
using netcore_repository_template.Models;

namespace netcore_repository_template.Data
{
  public class CommanderContext : DbContext
  {
    public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
    {
        
    }

    public DbSet<Command> Commands { get; set; }
  }
}