using System.ComponentModel;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
}