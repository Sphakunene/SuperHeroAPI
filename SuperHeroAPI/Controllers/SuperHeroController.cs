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
            List<SuperHero> result = await _superHeroService.getAllHeroes();
          
            return Ok(result);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> getHero(int id)
        {
            SuperHero result =  await _superHeroService.getHero(id);
            if (result is null) {
                return NotFound("Super Hero Not Found!");
            }
            return Ok(result);

        }
        [HttpPost]
        public async Task<ActionResult<SuperHero>> addHero(SuperHero hero)
        {
            _superHeroService.addHero(hero);
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
            _superHeroService.removeHero(id);


            return Ok(); 
        }
    }
}
