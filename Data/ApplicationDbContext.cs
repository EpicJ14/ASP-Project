using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bank4.Models;

namespace Bank4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bank4.Models.User>? User { get; set; } //потребители (клиенти)
        public DbSet<Bank4.Models.Card>? Card { get; set; } //кредитни/дебитни карти
    }
}
