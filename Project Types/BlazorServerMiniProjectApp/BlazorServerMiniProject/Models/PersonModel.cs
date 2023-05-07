using System.ComponentModel.DataAnnotations;

namespace BlazorServerMiniProject.Models;

public class PersonModel
{
    [Required]
    [StringLength(15, MinimumLength = 3)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(15, MinimumLength = 3)]
    public string? LastName { get; set; }
}