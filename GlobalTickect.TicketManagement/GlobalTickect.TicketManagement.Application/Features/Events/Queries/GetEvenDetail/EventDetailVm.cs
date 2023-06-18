using GlobalTickect.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenDetail
{
    public class EventDetailVm
    {
        public Guid EvenId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int price { get; set; }
        public string? Artist { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategorieId { get; set; }
        public CategoryDto Category { get; set; } = default!;
    }
}
