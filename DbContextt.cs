
using KartverkCase.Model;
using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
namespace KartverkCase
{

    public class DbContextt : DbContext
    {
        public DbContextt(DbContextOptions<DbContextt> options) : base(options)
        {
        }

        public DbSet<Bruker> Brukere { get; set; }
    }

}
