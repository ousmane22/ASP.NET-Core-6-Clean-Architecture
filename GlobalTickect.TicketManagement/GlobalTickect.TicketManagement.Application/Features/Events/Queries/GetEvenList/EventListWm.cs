using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenList
{
    public class EventListWm
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
