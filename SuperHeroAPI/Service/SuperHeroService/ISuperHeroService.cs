namespace SuperHeroAPI.Service.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> getAllHeroes();

        SuperHero getHero(int id);

        SuperHero addHero(SuperHero hero);

        SuperHero removeHero(int id);

        SuperHero updateHero(int id,SuperHero req);


    }
}
