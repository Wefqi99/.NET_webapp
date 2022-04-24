#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WefqiHobbiesWebApp.Models;

namespace WefqiHobbiesWebApp.Data
{
    public class WefqiHobbiesWebAppContext : DbContext
    {
        public WefqiHobbiesWebAppContext (DbContextOptions<WefqiHobbiesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WefqiHobbiesWebApp.Models.Game> Game { get; set; }

        public DbSet<WefqiHobbiesWebApp.Models.Pc> Pc { get; set; }

        public DbSet<WefqiHobbiesWebApp.Models.Show> Show { get; set; }
    }
}
