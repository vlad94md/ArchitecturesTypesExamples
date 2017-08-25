using CleanArchitecture.ApplicationCore.Entities;
using CleanArchitecture.ApplicationCore.Repositories;
using CleanArchitecture.Persistence.EF;
using CleanArchitecture.Persistence.Repositories;
using Ninject.Modules;

namespace CleanArchitecture.Persistence.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private readonly string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EfUnitOfWork>().WithConstructorArgument(connectionString);
            Bind<IRepository<Order>>().To<OrderRepository>();
            Bind<IRepository<Phone>>().To<PhoneRepository>();
        }
    }
}
