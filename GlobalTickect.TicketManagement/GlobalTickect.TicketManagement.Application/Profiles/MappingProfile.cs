using AutoMapper;
using GlobalTickect.TicketManagement.Application.Features.Categories.GetCategoriesList;
using GlobalTickect.TicketManagement.Application.Features.Events;
using GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenDetail;
using GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenList;
using GlobalTickect.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListWm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryEvenDto>().ReverseMap();
            CreateMap<Category, CategoryEvenListVm>().ReverseMap();
        }
    }
}
