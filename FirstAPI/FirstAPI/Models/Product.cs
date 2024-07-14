using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Models;

[Table("Product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Name { get; set; }

    [Required]
    [StringLength(300)]
    public string? Description { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public bool Stock { get; set;}
    public DateTime CreationDate { get; set; }

    [Required]
    [Column(TypeName="decimal(15,2)")]
    public decimal Value{ get; set; }
    public int CategoryId{ get; set; }
    public Category? Category { get; set; }
}
