using TodoList.Helper.Result;
using TodoList.Model;

namespace TodoList.Business.Abstract
{
    public interface IUserService
    {
        DataResult<List<User>> GetUsers();
        DataResult<User> GetUser(string email);
        void Add(User user);

    }
}
