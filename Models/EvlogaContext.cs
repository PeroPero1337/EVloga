using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVloga.Models
{
    public class EvlogaContext : IdentityDbContext<RegUser>
    {

        public DbSet<RegUser> regUsers { get; set; }
        public DbSet<OsebniPodatki> podatki { get; set; }
        public DbSet<Dokument> dokumenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=C:\USERS\PERO\DESKTOP\FORDESKTOPPC\UIKT GDPR\DB\EVLOGADB.MDF");
        }
    }
}
