namespace TDP36.WebUI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Moq;
    using TDP36.Domain.Abstract;
    using TDP36.Domain.Concrete;
    using TDP36.Domain.Entities;
    using System.Web.Mvc;
    using Ninject;

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
            kernel.Bind<IOpponentRepository>().To<EFOpponentRepository>();
            kernel.Bind<ICharacterRepository>().To<EFCharacterRepository>();
        }
    }
}