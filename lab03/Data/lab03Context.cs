using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab03.Models
{
    public class lab03Context : DbContext
    {
        public lab03Context (DbContextOptions<lab03Context> options)
            : base(options)
        {
        }

        public DbSet<lab03.Models.Carro> Carro { get; set; }
    }
}
