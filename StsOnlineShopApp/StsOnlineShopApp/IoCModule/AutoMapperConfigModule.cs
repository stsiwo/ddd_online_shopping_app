using StsOnlineShopApp.Config;
using Autofac;
using AutoMapper;

namespace StsOnlineShopApp.IoCModule
{
    public class AutoMapperConfigModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var config = new MapperConfiguration(m =>
            {
                m.AddProfile(new AppProfile());
            });

            IMapper mapper = config.CreateMapper();

            builder
                .RegisterInstance(mapper)
                .As<IMapper>()
                .InstancePerLifetimeScope();

        }
        
    }
}
