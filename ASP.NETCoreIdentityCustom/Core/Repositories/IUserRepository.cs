using MyIceDream.Areas.Identity.Data;

namespace MyIceDream.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();

        ApplicationUser GetUser(string id);

        ApplicationUser UpdateUser(ApplicationUser user);
        ApplicationUser AddUser(ApplicationUser user);

    }
}
