using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class NationalPark
  {
    public int NationalParkId { get; set; }
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
    [StringLength(100000)]
    public string Description { get; set; }
  }
}