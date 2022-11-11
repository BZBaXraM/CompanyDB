using System.ComponentModel.DataAnnotations;

namespace CompanyDB;

public class Salaries
{
    [Required] public int Id { get; set; }
    [Required] public double Salary { get; set; }
}