using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public ClientDetail Get(int id)
        {
            using (var ctx = new dbcompdemoContext())
            {
                return ctx.ClientDetails.Find(id);
            }
        }
        [Authorize]
        public IEnumerable<ClientDetail> GetAll(int id)
        {
            using (var ctx = new dbcompdemoContext())
            {
                return ctx.ClientDetails.ToList();
            }
        }
    }
}