using MediatR;
using MyBlog.Data;
using MyBlog.Data.IService;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.MediatR.Commands.UserCommand
{
    public static class AddUser
    {
        public record Command(User user) : IRequest<Response<int>>;

        public class Handler : IRequestHandler<Command, Response<int>>
        {
            private IUserService _UserService;

            public Handler(IUserService userService)
            {
                _UserService = userService;
            }
            public async Task<Response<int>> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var result = _UserService.AddUser(request.user);
                    return Response.OK<int>(result);
                }
                catch (Exception ex)
                {
                    return Response.Fail<int>(ex.Message);
                }
            }
        }
    }
}
