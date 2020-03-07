using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Newtonsoft.Json;

namespace Facpag.Application.Models.Bill.Commands
{
    public class CreatedBillEventHandler : INotificationHandler<CreatedBillEvent>
    {
        public async Task Handle(CreatedBillEvent notification, CancellationToken cancellationToken)
        {
            //TODO: Enviar a una cola de envio de correo electronico la factura, para posteriormente enviar un email 
            // al cliente con los datos de la factura. 
            Console.WriteLine($"Factura: {JsonConvert.SerializeObject(notification)}");
        }
    }
}
