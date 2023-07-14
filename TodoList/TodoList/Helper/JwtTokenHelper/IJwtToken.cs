using TodoList.Model.Dto;

namespace TodoList.Helper.JwtTokenHelper
{
    public interface IJwtToken
    {
        string CreateAccessToken(UserForLogin user);
    }
}
