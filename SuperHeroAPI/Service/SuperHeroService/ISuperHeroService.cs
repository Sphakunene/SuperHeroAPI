namespace SuperHeroAPI.Service.SuperHeroService
{
    public interface ISuperHeroService
    {
       Task<List<SuperHero>> getAllHeroes();

        Task<SuperHero> getHero(int id);

        Task<SuperHero> addHero(SuperHero req);

        Task<SuperHero> removeHero(int id);

       Task<SuperHero> updateHero(int id,SuperHero req);


    }
}
