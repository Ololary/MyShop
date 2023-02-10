using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }
    [System.ComponentModel.DataAnnotations.Required]
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    [System.ComponentModel.DataAnnotations.Required]
    [Range(1,int.MaxValue,ErrorMessage = "Display Order for the category must be greather then 0")]
    public int DisplayOrder { get; set; }
}