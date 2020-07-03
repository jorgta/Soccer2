namespace Soccer2.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Soccer2.Web.Data.Entities;

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TeamEntity> Teams { get; set; }
    }

}
