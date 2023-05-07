using System.ComponentModel.DataAnnotations;

namespace BlazorServerMiniProject.Models;

public class AddressModel
{
    [Required]
    [StringLength(30, MinimumLength = 4)]
    public string? Street { get; set; }
    [Required]
    [StringLength(30, MinimumLength = 4)]
    public string? City { get; set; }
    [Required]
    [StringLength(30, MinimumLength = 4)]
    public string? State { get; set; }
    [Required]
    [StringLength(30, MinimumLength = 4)]
    public string? ZipCode { get; set; }
}