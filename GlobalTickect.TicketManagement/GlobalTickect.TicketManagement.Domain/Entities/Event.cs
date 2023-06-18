using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Domain.Entities
{
    public class Event
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
