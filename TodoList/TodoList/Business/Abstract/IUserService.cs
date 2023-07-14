using TodoList.Model;

namespace TodoList.Business.Abstract
{
    public interface IUserService
    {
        User GetUser(string email);
        void Add(User user);

    }
}
