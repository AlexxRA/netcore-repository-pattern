using AutoMapper;
using netcore_repository_template.DTOs;
using netcore_repository_template.Models;

namespace netcore_repository_template.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
        //Source -> Target
        CreateMap<Command, CommandReadDto>();

        CreateMap<CommandCreateDto, Command>();
        
        CreateMap<CommandUpdateDto, Command>();
    }
  }
}