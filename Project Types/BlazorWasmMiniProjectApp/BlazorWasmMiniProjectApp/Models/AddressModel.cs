using System.ComponentModel.DataAnnotations;

namespace BlazorWasmMiniProjectApp.Models;

public class AddressModel
{
    [Required]
    public string? Street { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? State { get; set; }
    [Required]
    public string? ZipCode { get; set; }
}