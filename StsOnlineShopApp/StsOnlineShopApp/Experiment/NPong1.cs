using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace StsOnlineShopApp.Experiment
{
    public class NPong1 : INotificationHandler<NPing>
    {
        public Task Handle(NPing notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("NPong1");
            return Task.CompletedTask;
        }
    }
    public class NPong2 : INotificationHandler<NPing>
    {
        public Task Handle(NPing notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("NPong2");
            return Task.CompletedTask;
        }
    }

}
