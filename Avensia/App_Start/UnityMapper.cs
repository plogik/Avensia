using Avensia.Data;
using Avensia.Data.Repositories;
using Avensia.Data.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Mvc5;

namespace Avensia.App_Start
{
    public class UnityMapper
    {
        public static void InitMappings()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductRepository, ProductNHibernateRepository>();
            container.RegisterType<IProductService, ProductNHibernateService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}