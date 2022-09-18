using AppCoreWeb.ViewModel;

namespace AppCoreWeb.BAL
{
    public interface IUsersService
    {
        List<UsersViewModel> GetAll();
    }
}
