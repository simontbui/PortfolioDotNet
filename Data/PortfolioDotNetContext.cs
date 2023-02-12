using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioDotNet.Models;

namespace PortfolioDotNet.Data
{
    public class PortfolioDotNetContext : DbContext
    {
        public PortfolioDotNetContext (DbContextOptions<PortfolioDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<PortfolioDotNet.Models.Comment> Comment { get; set; } = default!;
    }
}
