using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data_Access;

namespace SuperHeroAPI.Service.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {

        private readonly SuperHeroDBContext dbContext;
        public SuperHeroService(SuperHeroDBContext superHeroDBContext)
        {
            dbContext = superHeroDBContext;
        }
        private static List<SuperHero> superHero = new List<SuperHero> {

            new SuperHero { Id = 1,
                Name = "Spider Man",
                FirstName="Peter",
                LastName= "Parker",
                Place="New York City"
            },
            new SuperHero { Id = 2,
                Name = "BatMan",
                FirstName="Paul",
                LastName= "Smith",
                Place="Dubai"
            },
            new SuperHero { Id = 3,
                Name = "Goku",
                FirstName="Son",
                LastName= "Yew",
                Place="bangkok"
            }
        };
        public async Task<SuperHero> addHero(SuperHero req)
        {
            superHero.Add(req);

            return req;
        }

        public  async Task<List<SuperHero>> getAllHeroes()
        {
            var hero = await dbContext.superHeroes.ToListAsync();
        }

        public async Task<SuperHero> getHero(int id)
        {
            SuperHero result =   superHero.Find((x => x.Id == id));

            if (result == null)
            {
                return null;
            }

            return result;
        }

        public async Task<SuperHero> removeHero(int id)
        {
            var result = superHero.Find(x => x.Id == id);
            superHero.Remove(result); 
            return result;
        }

        public async Task<SuperHero> updateHero(int id, SuperHero req) {
            var hero = superHero.Find(x => x.Id == id);

            if (hero is null)
            {
                return null;
            }
            hero.Name = req.Name;
            hero.FirstName = req.FirstName;
            hero.LastName = req.LastName;
            hero.Place = req.Place;

            return hero; 
        }
    }
}
