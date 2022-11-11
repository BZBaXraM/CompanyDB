using System.ComponentModel.DataAnnotations;

namespace CompanyDB;

public class Company
{
    [Required] public int Id { get; set; }
    [Required] public string? Name { get; set; }
}