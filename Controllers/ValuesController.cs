using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        protected readonly dbContextApi db;
        public ValuesController(dbContextApi _db) => db = _db;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return db.User.ToList();
        }

        // GET api/values/id
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return db.User.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User usuario)
        {
            db.User.Add(usuario);
            db.SaveChanges();
        }
    }
}
