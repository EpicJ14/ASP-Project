using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Data.Entity;

namespace BankSys.Models
{
    public class DbServicesContext : DbContext
    {
        public DbSet<User> users { get; set; }
    }
}
