using TodoList.Helper.Result;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Business.Abstract
{
    public interface IAuthService
    {

        UserForLogin Login(UserForLogin user);
        string CreateToken(UserForLogin user);
        DataResult<UserForRegister> Register(UserForRegister user);
    }
}
