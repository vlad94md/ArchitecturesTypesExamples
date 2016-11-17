using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using NLayerApp.DAL.Interfaces;
using NLayerApp.DAL.Repositories;

namespace NLayerApp.BLL.Infrastructure
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
        }
    }
}
