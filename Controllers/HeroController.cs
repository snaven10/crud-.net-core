using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroController : Controller
    {
        private readonly HeroDbContext dbContext;
        public HeroController(HeroDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hero>> Get()
        {
            return Ok(dbContext.Heroes.ToList());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Hero hero)
        {
            dbContext.Heroes.Add(hero);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpPost("update/{id:int}")]
        public ActionResult Post(int id, [FromBody] Hero hero)
        {
            var heroes = dbContext.Heroes.First(a => a.Id == id);
            heroes.Name = hero.Name;
            heroes.SuperPower = hero.SuperPower;
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("remove/{id:int}")]
        public ActionResult Delete(int id)
        {
            var hero = dbContext.Heroes.Where(r => r.Id.Equals(id)).FirstOrDefault();
            dbContext.Heroes.Remove(hero);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}