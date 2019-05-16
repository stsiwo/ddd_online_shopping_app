using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace StsOnlineShopApp.UI.UICommand
{
    public class DemoCommandHandler : IRequestHandler<DemoCommand, DTO>
    {
        public Task<DTO> Handle(DemoCommand request, CancellationToken cancellationToken)
        {
            DTO response = new DemoDTO(request.Id, request.Name);
            return Task.FromResult(response);
        }
    }
}
