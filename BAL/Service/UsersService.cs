using AppCoreWeb.ViewModel;
using AppCoreWeb.DAL;

namespace AppCoreWeb.BAL
{
    public class UsersService : IUsersService
    {
        public IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public List<UsersViewModel> GetAll()
        {
            return _usersRepository.GetAll();
        }
    }
}
