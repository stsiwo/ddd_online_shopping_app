using Autofac;
using MediatR;
    
namespace StsOnlineShopApp
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // mediator itself
            builder
              .RegisterType<Mediator>()
              .As<IMediator>()
              .InstancePerLifetimeScope();

            // request & notification handlers
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });
        }
    }
}
