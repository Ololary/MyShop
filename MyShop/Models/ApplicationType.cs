using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class ApplicationType
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

}