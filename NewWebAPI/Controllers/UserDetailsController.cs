using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly next3plContext _context;

        public UserDetailsController(next3plContext context)
        {
            _context = context;
        }

        // GET: api/<UserDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDetails>>> GetUserDetails()
        {
            //return new string[] { "value1", "value2" };
            
                var models = await _context.UserDetails.FromSqlRaw("select Users.FirstName, Users.Email, Avatar.Url from Users inner join Avatar on Users.Id=Avatar.IdUser").ToListAsync();    // E.g.: "SELECT * FROM apple A JOIN banana B ON A.col = B.col"
                return models;
            
        }

        // GET api/<UserDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<UserDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
