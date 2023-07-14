using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.Model;

namespace TodoList.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public User GetUser(string email)
        {
            var user = _userRepository.Get(x=>x.Email==email);
            return user;
        }
    }
}
