
using ApiNet9._0.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiNet9._0.Data
{
    public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
    {
       public DbSet<ApiModel> ApiModels { get; set; }
    }
}
