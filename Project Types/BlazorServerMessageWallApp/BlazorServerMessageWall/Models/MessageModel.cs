using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;

public class MessageModel
{
    [Required]
    [StringLength(10, MinimumLength = 5)]
    public String? Message { get; set; }
}