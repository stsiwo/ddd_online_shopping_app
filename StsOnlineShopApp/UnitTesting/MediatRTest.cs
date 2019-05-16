using System;
using Xunit;
using Xunit.Abstractions;
using Autofac;
using MediatR;
using StsOnlineShopApp.Experiment.UICommand;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class MediatRTest : Test
    {
        public MediatRTest(ITestOutputHelper output) : base(output)
        {

        }

        [Fact]
        public async Task sampleTest()
        {
            var builder = new ContainerBuilder();

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

            builder.RegisterType<DemoCommandHandler>().AsImplementedInterfaces().InstancePerDependency();

            using (var container = builder.Build())
            using (var scope = container.BeginLifetimeScope())
            {
                IMediator myMediator = scope.Resolve<IMediator>();
                DemoCommand myCommand = new DemoCommand();
                DTO response = await myMediator.Send(myCommand);


                output.WriteLine(response.ToJson());


                Assert.Equal("a", "b");
            }
        }
    }
}
