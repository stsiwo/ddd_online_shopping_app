using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace UnitTesting
{
    public abstract class Test
    {
        protected readonly ITestOutputHelper output;

        public Test(ITestOutputHelper output)
        {
            this.output = output;
            // use this when want to check something in console
            // output.WriteLine(expression.Parameters.Single().ToString());
        }
    }
}
