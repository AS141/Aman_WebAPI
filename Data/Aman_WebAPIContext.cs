using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aman_WebAPI.Models;

namespace Aman_WebAPI.Data
{
    public class Aman_WebAPIContext : DbContext
    {
        public Aman_WebAPIContext (DbContextOptions<Aman_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Aman_WebAPI.Models.Books> Books { get; set; }
    }
}
