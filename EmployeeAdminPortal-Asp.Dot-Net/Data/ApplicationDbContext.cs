using EmployeeAdminPortal_Asp.Dot_Net.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal_Asp.Dot_Net.Data;

public class ApplicationDbContext: DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Employee>  Employees { get; set; }
    
}