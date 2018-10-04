using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernal;

        public NinjectDependencyResolver(IKernel kernalParam)
        {
            kernal = kernalParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernal.TryGet(serviceType);
        }

        private void AddBindings()
        {
            kernal.Bind<IValueCalculator>().To<LinqValueCalculator>();
        }
    }

}