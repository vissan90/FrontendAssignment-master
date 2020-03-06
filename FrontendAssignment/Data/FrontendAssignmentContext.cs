using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FrontendAssignment.Model;

namespace FrontendAssignment.Data
{
    public class FrontendAssignmentContext : DbContext
    {
        public FrontendAssignmentContext (DbContextOptions<FrontendAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<FrontendAssignment.Model.Products> Products { get; set; }
    }
}
