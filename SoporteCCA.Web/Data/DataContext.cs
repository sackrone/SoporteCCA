using Microsoft.EntityFrameworkCore;
using SoporteCCA.Web.Data.Entities;

namespace SoporteCCA.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Modelorama> Modeloramas { get; set; }
    }
}
