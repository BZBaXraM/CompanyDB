using System.ComponentModel.DataAnnotations;

namespace CompanyDB;

public class Employees
{
    [Required] public int Id { get; set; }
    [Required] public string? FirstName { get; set; }
    [Required] public string? LastName { get; set; }
    [Required] public int Age { get; set; }
}