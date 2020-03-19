using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Assignees;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AssigneeController : BaseController {
        [HttpGet("list")]
        public async Task<ActionResult<List<Assignee>>> List () {
            return await Mediator.Send (new ListAssignees.Query ());
        }

        [HttpPost("addassignee")]
        public async Task<ActionResult<Unit>> Add (AddAssignee.Command command) 
        {
            return await Mediator.Send (command);
        }
    }
}