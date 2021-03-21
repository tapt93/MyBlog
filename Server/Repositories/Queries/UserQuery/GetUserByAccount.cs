using MediatR;
using MyBlog.Data;
using MyBlog.Data.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.MediatR.Queries.UserQuery
{
    public static class GetUserByAccount
    {
        public record Query(string account) : IRequest<Response<User>>;

        public class Handler : IRequestHandler<Query, Response<User>>
        {
            private IUserService _UserService;
            public Handler(IUserService userService)
            {
                _UserService = userService;
            }
            public async Task<Response<User>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    var result = _UserService.GetUserByAccount(request.account);
                    return Response.OK<User>(result);
                }
                catch (Exception ex)
                {
                    return Response.Fail<User>(ex.Message);
                }
            }
        }
    }
}
