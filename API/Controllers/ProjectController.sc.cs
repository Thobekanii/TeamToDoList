using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Projects;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController {
        [HttpGet ("list")]
        public async Task<ActionResult<List<Project>>> List () {
            return await Mediator.Send (new ListProjects.Query ());
        }

        [HttpPost ("addproject")]
        public async Task<ActionResult<Unit>> Create (AddProjects.Command command) {
            return await Mediator.Send (command);
        }
    }
}