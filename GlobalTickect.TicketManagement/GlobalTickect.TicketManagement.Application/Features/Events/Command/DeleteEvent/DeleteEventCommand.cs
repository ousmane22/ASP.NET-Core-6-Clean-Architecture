using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Command.DeleteEvent
{
    public class DeleteEventCommand:IRequest
    {
        public Guid EventId { get; set; }
    }
}
