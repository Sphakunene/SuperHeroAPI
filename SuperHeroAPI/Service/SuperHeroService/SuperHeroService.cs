namespace SuperHeroAPI.Service.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {

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
        public SuperHero addHero(SuperHero hero)
        {
            superHero.Add(hero);

            return hero;
        }

        public List<SuperHero> getAllHeroes()
        {
            return superHero;
        }

        public SuperHero getHero(int id)
        {
            SuperHero result = superHero.Find(x => x.Id == id);

            return result;
        }

        public SuperHero removeHero(int id)
        {
            var result = superHero.Find(x => x.Id == id);
            superHero.Remove(result); 
            return result;
        }

        public SuperHero updateHero(int id, SuperHero req) {
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
