using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PuzzlesoftApi.Model;

namespace PuzzlesoftApi.Controllers
{
    [Route("[controller]")]
    public class DalController : ControllerBase
    {
        private readonly dbcompdemoContext _context;

        public DalController(dbcompdemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok(true);
        }
        [Authorize]
        [HttpPost("dataset/{proc}")]
        public object GetDataset(string proc, [FromBody] Dictionary<string, object> args)
        {
            return _context.ExecuteProc($"pr_{proc.Replace("_", "")}", PrepareData(args), User);
        }
        [Authorize]
        [HttpPost("datatable/{proc}")]
        public object GetDatatable(string proc, [FromBody] Dictionary<string, object> args)
        {
            return _context.ExecuteProc($"pr_{proc.Replace("_", "")}", PrepareData(args), User)["Table"];
        }
        [Authorize]
        [HttpPost("value/{proc}")]
        public object GetValue(string proc, [FromBody] Dictionary<string, object> args)
        {
            return _context.ExecuteProcAndGetValue($"pr_{proc.Replace("_", "")}", PrepareData(args), User);
        }

        private Dictionary<string, object> PrepareData(Dictionary<string, object> args)
        {
            RetrieveUserData(args, "UserId", ClaimTypes.NameIdentifier);
            RetrieveUserData(args, "ProfileId");
            return args;
        }

        private void RetrieveUserData(Dictionary<string, object> args, string paramName, string type=null)
        {
            if (args.Remove($"Add{paramName}", out var param))
                args[string.IsNullOrWhiteSpace(param as string) ? paramName : param.ToString()] =
                    User.FindFirstValue(type ?? paramName);
        }
    }
}