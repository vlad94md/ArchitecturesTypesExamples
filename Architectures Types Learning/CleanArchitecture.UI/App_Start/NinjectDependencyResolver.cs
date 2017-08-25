using CleanArchitecture.ApplicationCore.Services.Concrete;
using CleanArchitecture.ApplicationCore.Services.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CleanArchitecture.UI
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IOrderService>().To<OrderService>();
        }
    }
}