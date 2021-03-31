using System.ComponentModel.DataAnnotations;

namespace netcore_repository_template.DTOs{
  public class CommandUpdateDto
  {      
      [Required]
      [MaxLength(250)]
      public string HowTo { get; set; }

      [Required]
      public string Line { get; set; }

      [Required]
      public string Platform { get; set; }
    
  }
}