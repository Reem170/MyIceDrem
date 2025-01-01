using MyIceDream.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace MyIceDream.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
