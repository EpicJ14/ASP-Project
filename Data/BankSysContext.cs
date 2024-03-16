using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankSys.Models;

namespace BankSys.Data
{
    public class BankSysContext : DbContext
    {
        public BankSysContext (DbContextOptions<BankSysContext> options)
            : base(options)
        {
        }

        public DbSet<BankSys.Models.User> User { get; set; } = default!;
    }
}
