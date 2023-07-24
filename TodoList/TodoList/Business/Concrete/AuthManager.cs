using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.Helper.JwtTokenHelper;
using TodoList.Helper.Result;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private IJwtToken _jwtToken;
        public AuthManager(IUserService userService, IJwtToken jwtToken, IUserRepository userRepository)
        {
            _jwtToken = jwtToken;
            _userService = userService;
            _userRepository = userRepository;
        }


        public DataResult<UserForLogin> Login(UserForLogin user)
        {
            var userCheck = _userService.GetUser(user.Email);

            if (!userCheck.Success)
            {

                return new DataResult<UserForLogin>(null,"Kullanıcı Bulunamadı",false);
            }
            if (userCheck.Data.Password !=user.Password)
            {
                return new DataResult<UserForLogin>(null, "Kullanıcı email veya şifre yanlış", false);
            }
            var userDto = new UserForLogin
            {
                Email = userCheck.Data.Email,
                Password = userCheck.Data.Password,
            };
            return new DataResult<UserForLogin>(userDto," ",true);
        }
        public DataResult<string> CreateToken(UserForLogin user)
        {
            var token = _jwtToken.CreateAccessToken(user);
            if (string.IsNullOrEmpty(token))
            {
                return new DataResult<string>(null, "Kullanıcı Adı veya Şifre bulunamadı", false);
            }
            return new DataResult<string>(token,"Giriş İşlemi Başarılı",true);
        }

        public DataResult<UserForRegister> Register(UserForRegister user)
        {
            var getUser = _userService.GetUser(user.Email);

            if (getUser.Data!=null)
            {
                return new DataResult<UserForRegister>(null, "Böyle Bir Kullanıcı Mrvcut", false);
            }
            var entity = new User
            {
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                Password = user.Password,
            };
            _userRepository.Add(entity);
            return new DataResult<UserForRegister>(user,"Kullanıcı Kayıt İşlemi Başarılı",true);
        }
    }
}
