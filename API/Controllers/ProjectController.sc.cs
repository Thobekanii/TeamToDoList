using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Projects;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController:BaseController
    {
       [HttpGet]
       public async Task<ActionResult<List<Project>>> List()
       {
           return await Mediator.Send(new ListProjects.Query());
       } 
    }
}