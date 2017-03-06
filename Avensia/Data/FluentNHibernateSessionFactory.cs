using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Avensia.Data
{
    public class FluentNHibernateSessionFactory
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("ProductDBConnStr")))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FluentNHibernateSessionFactory>())
                    .ExposeConfiguration(cfg =>
                    {
                        new SchemaUpdate(cfg).Execute(false, true);
                    })
                    .BuildSessionFactory();
        }
    }
}