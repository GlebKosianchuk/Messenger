using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMemeU.Controllers;

public record UserViewModel
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string UserName { get; init; }
    
    [Required]
    [StringLength(50, MinimumLength = 6)]
    public string Password { get; init; }

}