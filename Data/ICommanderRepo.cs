using System.Collections.Generic;
using netcore_repository_template.Models;

namespace netcore_repository_template.Data
{
  public interface ICommanderRepo
  {
    bool SaveChanges();
    
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int id);
    void CreateCommand(Command cmd);
    void UpdateCommand(Command cmd);
    void DeleteCommand(Command cmd);
  }
}