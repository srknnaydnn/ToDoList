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


        public UserForLogin Login(UserForLogin user)
        {
            var userCheck = _userService.GetUser(user.Email);

            if (userCheck == null)
            {

                return null;
            }
            var userDto = new UserForLogin
            {
                Email = userCheck.Email,
                Password = userCheck.Password,
            };
            return userDto;
        }
        public string CreateToken(UserForLogin user)
        {
            var token = _jwtToken.CreateAccessToken(user);
            return token;
        }

        public DataResult<UserForRegister> Register(UserForRegister user)
        {
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
