using CrudAspMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAspMVC.Data;
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }
      

    public DbSet<Category> Categories { get; set; }
    }