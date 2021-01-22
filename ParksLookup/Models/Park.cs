using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string State { get; set; }
    [Required]
    [StringLength(20)]
    public string Type { get; set; }
    [Required]
    [StringLength(1000)]
    public string Description { get; set; }
  }
} 