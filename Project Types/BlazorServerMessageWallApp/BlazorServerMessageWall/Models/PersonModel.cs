using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;

public class PersonModel
{
    [Required]
    [StringLength(25, MinimumLength = 3)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(25, MinimumLength = 3)]
    public string? LastName { get; set; }
}