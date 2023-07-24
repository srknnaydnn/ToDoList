using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.Helper.Result;
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

        public DataResult<User> GetUser(string email)
        {
            var user = _userRepository.Get(x=>x.Email==email);

            if (user==null)
            {
                return new DataResult<User>(null,"Kullanıcı Bulunamadı",false);
            }
            return new DataResult<User>(user," ",true);
        }

        public DataResult<List<User>> GetUsers()
        {
            var users = _userRepository.GetAll();
            return new DataResult<List<User>>(users,"Listeleme İşlemi Başarılı",true);
        }

    }
}
