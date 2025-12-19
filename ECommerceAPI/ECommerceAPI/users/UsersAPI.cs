using System.Runtime.CompilerServices;

namespace FirstMinimalAPI.users
{
    public static class UsersAPI
    {
        public static void ConfigureUsersAPI(this WebApplication app )
        {
            app.MapGet("/api/hello",GetHelloMessage);
        }
        public static  Task<IResult> GetHelloMessage()
        {
            return Task.FromResult(Results.Ok("hello"));
        }
    }
}
