using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Models;

namespace Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Data
{
    public class Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext : DbContext
    {
        public Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext (DbContextOptions<Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Models.Adidasi> Adidasi { get; set; } = default!;
    }
}
