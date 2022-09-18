
using AppCoreWeb.Model;
using AppCoreWeb.ViewModel;

namespace AppCoreWeb.DAL
{
    public class UsersRepository : IUsersRepository
    {
        private UsersDbContext _context;
        public UsersRepository(UsersDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<UsersViewModel> GetAll()
        {
            List<UsersViewModel> users = new List<UsersViewModel>();
            var result = _context.Users.ToList();
            foreach (var user in result)
            {
                users.Add(new UsersViewModel() { 
                FirstName = user.FirstName,
                });
            }
            return users;
        }
    }
}
