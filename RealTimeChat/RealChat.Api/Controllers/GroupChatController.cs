using Base.API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RealChat.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class GroupChatController : BaseController
    {
        public GroupChatController(ISender mediator) : base(mediator)
        {
        }
    }
}
