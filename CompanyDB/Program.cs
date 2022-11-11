using CompanyDB;
using Microsoft.EntityFrameworkCore;
using AppContext = CompanyDB.AppContext;

using (AppContext context = new AppContext())
{
    Employees employees = new Employees
    {
        FirstName = "Bahram", LastName = "Bayramzade", Age = 25
    };
    Employees employees2 = new Employees
    {
        FirstName = "Kenan", LastName = "Aliyev", Age = 23
    };
    Employees employees3 = new Employees
    {
        FirstName = "Nadir", LastName = "Zamanov", Age = 42
    };
    Employees employees4 = new Employees
    {
        FirstName = "Omar", LastName = "Nuriyev", Age = 16
    };
    Employees employees5 = new Employees
    {
        FirstName = "Sami", LastName = "Salahov", Age = 16
    };
    Employees employees6 = new Employees
    {
        // Я скучаю по ней…
        FirstName = "Aida", LastName = "Alasgarova", Age = 34
    };
    Employees employees7 = new Employees
    {
        FirstName = "Pasha", LastName = "Sultanov", Age = 23
    };
    Employees employees8 = new Employees
    {
        FirstName = "Bill", LastName = "Gates", Age = 67
    };
    Employees employees9 = new Employees
    {
        FirstName = "Elvin", LastName = "Azimov", Age = 21
    };
    Employees employees10 = new Employees
    {
        // No comment…
        FirstName = "Dolbayob", LastName = "Jony", Age = 222
    };
    Employees employees11 = new Employees
    {
        FirstName = "Sevil", LastName = "Bayramzade", Age = 26
    };
    Employees employees12 = new Employees
    {
        FirstName = "Polat", LastName = "Alemdar", Age = 55
    };
    Employees employees13 = new Employees
    {
        FirstName = "Jeffrey", LastName = "Richter", Age = 58
    };

    context.Employees?.AddRange(employees,
        employees2,
        employees3,
        employees4,
        employees5,
        employees6,
        employees7,
        employees8,
        employees9,
        employees10,
        employees11,
        employees12,
        employees13);

    context.SaveChanges();
}

using (AppContext context = new AppContext())
{
    Company company = new Company
    {
        Name = "Google"
    };
    Company company2 = new Company
    {
        Name = "Facebook"
    };
    Company company3 = new Company
    {
        Name = "STEP IT Academy Baku"
    };
    Company company4 = new Company
    {
        Name = "Anime Pictures Studio"
    };
    Company company5 = new Company
    {
        Name = "PornHub"
    };
    Company company6 = new Company
    {
        Name = "FHN"
    };
    Company company7 = new Company
    {
        Name = "LeoBank"
    };
    Company company8 = new Company
    {
        Name = "Microsoft"
    };
    Company company9 = new Company
    {
        Name = "STEP IT"
    };
    Company company10 = new Company
    {
        Name = "Dolbayob Production"
    };
    Company company11 = new Company
    {
        Name = "STEP IT Academy Junior"
    };
    Company company12 = new Company
    {
        Name = "KGT"
    };
    Company company13 = new Company
    {
        Name = "Microsoft"
    };

    context.Companies?.AddRange(company,
        company2, company3, company4, company5, company6, company7, company8,
        company9, company10, company11, company12, company13);

    context.SaveChanges();
}

using (AppContext context = new AppContext())
{
    Salaries salaries = new Salaries
    {
        Salary = 6000
    };
    Salaries salaries2 = new Salaries
    {
        Salary = 6000
    };
    Salaries salaries3 = new Salaries
    {
        Salary = 455
    };
    Salaries salaries4 = new Salaries
    {
        Salary = 2500
    };
    Salaries salaries5 = new Salaries
    {
        Salary = 600
    };
    Salaries salaries6 = new Salaries
    {
        Salary = 5290
    };
    Salaries salaries7 = new Salaries
    {
        Salary = 1000
    };
    Salaries salaries8 = new Salaries
    {
        Salary = 1502
    };
    Salaries salaries9 = new Salaries
    {
        Salary = 1299
    };
    Salaries salaries10 = new Salaries
    {
        Salary = 50
    };
    Salaries salaries11 = new Salaries
    {
        Salary = 8000
    };
    Salaries salaries12 = new Salaries
    {
        Salary = 10000
    };
    Salaries salaries13 = new Salaries
    {
        Salary = 8900
    };

    context.Salaries?.AddRange(salaries,
        salaries2,
        salaries3,
        salaries4,
        salaries5,
        salaries6,
        salaries7,
        salaries8,
        salaries9,
        salaries10, salaries11, salaries12, salaries13);
    context.SaveChanges();
}

using (AppContext context = new AppContext())
{
    // var cnt = context.Companies?.Where(x => x.Name == "FHN").ToList();
    // var cnt = context.Companies?.ToList();
    var cnt = context.Employees?.ToList();
    var cmp = context.Companies?.ToList();
    var slr = context.Salaries?.ToList();
    foreach (var item in cnt!)
    {
        Console.WriteLine($" {item.Id} - {item.FirstName} - {item.LastName} - {item.Age}");
    }

    Console.WriteLine();

    foreach (var item in cmp!)
    {
        Console.WriteLine($"{item.Id} - {item.Name}");
    }

    Console.WriteLine();
            
    foreach (var item in slr!)
    {
        Console.WriteLine($"{item.Id} {item.Salary}$");
    }

    Console.WriteLine();
}