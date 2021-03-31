using System.Collections.Generic;
using netcore_repository_template.Models;

namespace netcore_repository_template.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>{
        new Command{Id=0, HowTo="Do something useful", Line="Whatever", Platform="Online"},
        new Command{Id=1, HowTo="Code", Line="Dont know", Platform="Online"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id=0, HowTo="Do something useful", Line="Whatever", Platform="Online"};
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }
  }
}