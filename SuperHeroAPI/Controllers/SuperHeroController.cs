using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Model;
using SuperHeroAPI.Service.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService=superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> getAllHeroes()
        {
            return Ok(superHero);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> getHero(int id)
        {
            var hero = superHero.Find(x => x.Id == id);

            if (hero is null)
            {
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

        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> updateHero(int id, SuperHero _hero)
        {
            var result = _superHeroService.updateHero(id, _hero);

            if (result is null) {
                return  NotFound("Super Hero not Found!");
            }
            return Ok(result);

            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> deleteHero(int id)
        {
            var hero = superHero.Find(x => x.Id == id);

            if (hero is null)
            {
                return NotFound("Sorry the hero is not found");
            }
           superHero.Remove(hero);

            return Ok(hero);
        }
    }
}
