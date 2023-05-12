﻿namespace SuperHeroAPI.Service.SuperHeroService
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
            throw new NotImplementedException();
        }

        public List<SuperHero> getAllHeroes()
        {
            throw new NotImplementedException();
        }

        public SuperHero getHero(int id)
        {
            throw new NotImplementedException();
        }

        public SuperHero removeHero(int id)
        {
            throw new NotImplementedException();
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
