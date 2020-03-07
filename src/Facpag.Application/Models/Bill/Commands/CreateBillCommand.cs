using System.Collections.Generic;
using MediatR;

namespace Facpag.Application.Models.Bill.Commands
{
    public class CreateBillCommand : IRequest<CommandResult>
    {
        public string client { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string paymentType { get; set; }
        public List<ResponseDetail> detail { get; set; }
    }

}
