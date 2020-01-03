using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Assignees;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssigneeController:BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Assignee>>> List()
        {
            return await Mediator.Send(new ListAssignees.Query());
        }
    }
}