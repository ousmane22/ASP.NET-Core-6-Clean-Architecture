using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenList
{
    public class GetEvensListQuery : IRequest<List<EventListWm>>
    {

    }
}
