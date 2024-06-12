using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class WebDbContext : DbContext
    {

        public WebDbContext (DbContextOptions<WebDbContext> options) : base(options)
        { }
        public DbSet<DataModel> DataModels { get; set; }


    }
}
