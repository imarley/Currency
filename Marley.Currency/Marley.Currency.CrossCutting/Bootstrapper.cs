using Marley.Currency.Data.Repositories;
using Marley.Currency.Domain.Interfaces.Repositories;
using Marley.Currency.Domain.Interfaces.Services;
using Marley.Currency.Domain.Services;
using SimpleInjector;

namespace Marley.Currency.CrossCutting
{
    public static class Bootstrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            //container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            //container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
        }
    }
}