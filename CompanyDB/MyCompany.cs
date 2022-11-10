using System.ComponentModel.DataAnnotations;

namespace CompanyDB;

public class MyCompany
{
    [Required] public int Id { get; set; }
    [Required] public string? Company { get; set; }
    [Required] public string? Employee { get; set; }
    [Required] public int Age { get; set; }
    [Required] public double Salary { get; set; }
}