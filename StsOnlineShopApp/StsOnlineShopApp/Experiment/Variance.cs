using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Experiment
{
    public interface ICovariant<out T> { }
    public interface IContravariant<in T> { }
    public interface INormal<T> { }

    public class Covariant<T> : ICovariant<T> { }
    public class Contravariant<T> : IContravariant<T> { }

    public class Normal<T> : INormal<T> { }

    public class Parent { }
    public class Child : Parent { }
    public class Variance
    {
        public void Covariant(ICovariant<Parent> parent)
        {

        } 

        public void Contravariant(IContravariant<Child> child) { }

        public void Contravariance(IContravariant<Child> child) { }
        public void Covariance()
        {
            ICovariant<Parent> parent = new Covariant<Parent>();
            ICovariant<Child> child = new Covariant<Child>();

            ICovariant<Parent> pa = new Covariant<Child>();

            Covariant(parent);
            Covariant(child);

            Func<Child, Parent> func = c => c;




        }
    }
}
