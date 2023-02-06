using Base.API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealChat.Application.Commands.Register;

namespace TicketManagement.Identity.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class IdentityController : BaseController
    {
        public IdentityController(ISender mediator) : base(mediator)
        {
        }

        #region Commands
        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<ActionResult<string>> RegisterUser(RegisterCommand command)
        {
            return Ok(await Mediator.Send(command, CancellationToken));
        }




        #endregion
    }
}