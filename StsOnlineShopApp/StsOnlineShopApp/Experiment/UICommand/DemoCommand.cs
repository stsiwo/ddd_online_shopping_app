using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace StsOnlineShopApp.Experiment.UICommand
{
    public class DemoCommand : IRequest<DTO>
    {
        public String Id { get; private set; }
        public String Name { get; private set; }

        public DemoCommand()
        {
            this.Id = "1";
            this.Name = "satoshi";
        }
    }
}
