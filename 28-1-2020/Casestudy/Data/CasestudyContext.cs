using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Casestudy.Models;

namespace Casestudy.Data
{
    public class CasestudyContext : DbContext
    {
        public CasestudyContext (DbContextOptions<CasestudyContext> options)
            : base(options)
        {
        }

        public DbSet<Casestudy.Models.Customer> Customer { get; set; }
    }
}
