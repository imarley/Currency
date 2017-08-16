using Marley.Currency.Domain.DataEntities;
using Marley.Currency.Domain.Interfaces.Repositories;

namespace Marley.Currency.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}