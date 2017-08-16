using Marley.Currency.Domain.DataEntities;
using Marley.Currency.Domain.Interfaces.Repositories;
using Marley.Currency.Domain.Interfaces.Services;

namespace Marley.Currency.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        #region Fields

        private readonly IUserRepository _userRepository;

        #endregion

        #region Constructors

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region Methods

        #endregion
    }
}