using System;
using Xunit;
using Xunit.Abstractions;
using Autofac;
using System.Collections.Generic;
using Autofac.Core;

namespace UnitTesting
{
    public class SampleDITest : Test
    {
        public SampleDITest(ITestOutputHelper output) : base(output)
        {

        }

        public class RuleManager
        {
            public RuleManager(IEnumerable<IRule> rules)
            {
                this.Rules = rules;
            }

            public IEnumerable<IRule> Rules { get; private set; }
        }

        public interface IRule { }

        public class SingletonRule : IRule
        {
            public SingletonRule(InstancePerRequestDependency dep) { }
        }

        public class InstancePerRequestDependency : IRule { }


        [Fact]
        public void CaptiveDependency()
        {
            var builder = new ContainerBuilder();

            // Again, the rule manager is a single-instance component,
            // resolved from the root lifetime and cached thereafter.
            builder.RegisterType<RuleManager>()
                   .SingleInstance();

            // This rule is registered as a singleton. Like the rule manager
            // it will only ever be resolved one time and will be resolved
            // from the root lifetime scope.
            builder.RegisterType<SingletonRule>()
                   .As<IRule>()
                   .SingleInstance();

            // This rule is registered on a per-request basis. It only exists
            // during the request.
            builder.RegisterType<InstancePerRequestDependency>()
                   .As<IRule>()
                   .InstancePerMatchingLifetimeScope("request");

            using (var container = builder.Build())
            using (var scope = container.BeginLifetimeScope("request"))
            {
                // PROBLEM: When the SingletonRule is resolved as part of the dependency
                // chain for the rule manager, the InstancePerRequestDependency in
                // the rule constructor will fail to be resolved because the rule
                // is coming from the root lifetime scope but the InstancePerRequestDependency
                // doesn't exist there.
                Assert.Throws<DependencyResolutionException>(() => scope.Resolve<RuleManager>());
            }
        }
    }
}
