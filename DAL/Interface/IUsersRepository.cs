using AppCoreWeb.ViewModel;

namespace AppCoreWeb.DAL
{
    public interface IUsersRepository
    {
        List<UsersViewModel> GetAll();
    }
}
