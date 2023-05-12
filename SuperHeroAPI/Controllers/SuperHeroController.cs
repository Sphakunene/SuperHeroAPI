using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Model;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
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

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> getAllHeroes() {
            return Ok(superHero);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> getHero(int id)
        {
            var hero = superHero.Find(x => x.Id == id);

            if (hero is null) {
                return NotFound("Sorry the hero is not found");
            }
            return Ok(hero);

        }
        [HttpPost]
        public async Task<ActionResult<SuperHero>> addHero(SuperHero hero)
        {
            superHero.Add(hero);
            return Ok(hero);

        }


    }
}
