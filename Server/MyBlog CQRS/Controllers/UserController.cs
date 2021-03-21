using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Data;
using MyBlog.MediatR;
using MyBlog.MediatR.Commands.UserCommand;
using MyBlog.MediatR.Queries.UserQuery;
using System.Threading.Tasks;

namespace MyBlog_CQRS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Response<int>> AddNewUser([FromBody] User user)
        {
            var result = await _mediator.Send(new AddUser.Command(user));
            return result;
        }

        [HttpGet]
        public async Task<Response<User>> GetUserByAccount(string account)
        {
            var result = await _mediator.Send(new GetUserByAccount.Query(account));
            return result;
        }
    }
}
