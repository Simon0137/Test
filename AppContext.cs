using System.Data.Entity;

namespace Test
{
    internal class AppContext : DbContext
    {
        public AppContext()
            : base("DBConnection")
            { }

        public DbSet<User> Users { get; set; }
    }
}
