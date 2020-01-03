using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Status;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController:BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Domain.Status>>> List()
        {
            return await Mediator.Send(new ListStatus.Query());
        }
    }
}