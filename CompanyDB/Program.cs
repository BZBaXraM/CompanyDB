using Microsoft.EntityFrameworkCore;

namespace CompanyDB;

internal class Program
{
    static void Main()
    {
        // using (AppContext context = new AppContext())
        // {
        //     MyCompany company = new MyCompany
        //     {
        //         Company = "Google", Employee = "Bahram Bayramzade", Age = 25, Salary = 3000
        //     };
        //     MyCompany company2 = new MyCompany
        //     {
        //         Company = "Facebook", Employee = "Kenan Aliyev", Age = 23, Salary = 3000
        //     };
        //     MyCompany company3 = new MyCompany
        //     {
        //         Company = "STEP IT Academy Baku", Employee = "Nadir Zamanov", Age = 42, Salary = 430
        //     };
        //     MyCompany company4 = new MyCompany
        //     {
        //         Company = "Anime Pictures Studio", Employee = "Omar Nuriyev", Age = 16, Salary = 1090
        //     };
        //     MyCompany company5 = new MyCompany
        //     {
        //         Company = "PornHub", Employee = "Sami Salahov", Age = 16, Salary = 5000
        //     };
        //     MyCompany company6 = new MyCompany
        //     {
        //         // Я скучаю по ней…
        //         Company = "FHN", Employee = "Aida Alasgarova", Age = 34, Salary = 600
        //     };
        //     MyCompany company7 = new MyCompany
        //     {
        //         Company = "LeoBank", Employee = "Pasha Sultanov", Age = 23, Salary = 900
        //     };
        //     MyCompany company8 = new MyCompany
        //     {
        //         Company = "Microsoft", Employee = "Bill Gates", Age = 67, Salary = 9000
        //     };
        //     MyCompany company9 = new MyCompany
        //     {
        //         Company = "STEP IT", Employee = "Elvin Azimov", Age = 21, Salary = 430
        //     };
        //     MyCompany company10 = new MyCompany
        //     {
        //         // No comment…
        //         Company = "Dolbayob", Employee = "Jony", Age = 222, Salary = 10
        //     };
        //     MyCompany company11 = new MyCompany
        //     {
        //         Company = "STEP IT Academy Junior", Employee = "Sevil Bayramzade", Age = 26, Salary = 500
        //     };
        //     MyCompany company12 = new MyCompany
        //     {
        //         Company = "KGT", Employee = "Polat Alemdar", Age = 55, Salary = 5000
        //     };
        //     MyCompany company13 = new MyCompany
        //     {
        //         Company = "Microsoft", Employee = "Jeffrey Richter", Age = 58, Salary = 5000
        //     };
        //
        //     context.Companies?.Add(company);
        //     context.Companies?.Add(company2);
        //     context.Companies?.Add(company3);
        //     context.Companies?.Add(company4);
        //     context.Companies?.Add(company5);
        //     context.Companies?.Add(company6);
        //     context.Companies?.Add(company7);
        //     context.Companies?.Add(company8);
        //     context.Companies?.Add(company9);
        //     context.Companies?.Add(company10);
        //     context.Companies?.Add(company11);
        //     context.Companies?.Add(company12);
        //     context.Companies?.Add(company13);
        //
        //     context.SaveChanges();
        // }

        using (AppContext context = new AppContext())
        {
            //var cnt = context.Companies?.Where(x => x.Company == "FHN").ToList();
            var cnt = context.Companies?.ToList();
            foreach (var item in cnt!)
            {
                Console.WriteLine($" {item.Id} - {item.Company} - {item.Employee} - {item.Age} - {item.Salary}");
            }
        }
    }
}