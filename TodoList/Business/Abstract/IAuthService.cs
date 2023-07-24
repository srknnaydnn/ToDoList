using TodoList.Helper.Result;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Business.Abstract
{
    public interface IAuthService
    {

        DataResult<UserForLogin> Login(UserForLogin user);
        DataResult<string> CreateToken(UserForLogin user);
        DataResult<UserForRegister> Register(UserForRegister user);
    }
}
