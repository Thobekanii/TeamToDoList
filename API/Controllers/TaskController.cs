using System.Threading.Tasks;
using Application.Task;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController:BaseController
    {
        [HttpPost]
        public async Task<ActionResult<Unit>> Create (CreateTask.Command command)
        {
            return await Mediator.Send(command);
        }
    }
}