using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data_Access
{
    public class SuperHeroDBContext: DbContext
    {

        public SuperHeroDBContext(DbContextOptions options): base(options)  { }
        public DbSet<SuperHero> superHeroes { get; set; }


    }
}
