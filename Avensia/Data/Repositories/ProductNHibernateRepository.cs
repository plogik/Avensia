using Avensia.Data.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avensia.Data.Repositories
{
    public class ProductNHibernateRepository : IProductRepository
    {
        public Product GetById(string id)
        {
            var sessionFactory = FluentNHibernateSessionFactory.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                return session.Query<Product>().Where(p => p.Id == id).Single();
            }
        }

        public Product GetFirst()
        {
            var sessionFactory = FluentNHibernateSessionFactory.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                return session.Query<Product>().First();
            }
        }

        public void SaveOrUpdate(Product product)
        {
            var sessionFactory = FluentNHibernateSessionFactory.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(product);
                    tx.Commit();
                }
            }
        }
    }
}