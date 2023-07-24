using TodoList.DataAccess.Abstract;
using TodoList.Model;

namespace TodoList.DataAccess.Concrete
{
    public class UserRepository:EntityRepository<User,AppDbContext>,IUserRepository
    {

    }
}
