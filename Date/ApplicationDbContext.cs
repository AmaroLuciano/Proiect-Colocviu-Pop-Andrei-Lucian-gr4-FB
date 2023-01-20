using Microsoft.EntityFrameworkCore;
using Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Models;

namespace Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Date
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet <GheteOrder>GheteOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        { 
        }
            }
}
