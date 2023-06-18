using AutoMapper;
using GlobalTickect.TicketManagement.Application.Contracts.Persistence;
using GlobalTickect.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenList
{
    public class GetEventListHandler : IRequestHandler<GetEvensListQuery, List<EventListWm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _asyncRepository;

        public GetEventListHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _asyncRepository = eventRepository;
        }
        public async Task<List<EventListWm>> Handle(GetEvensListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _asyncRepository.ListAsync())
                .OrderBy(x => x.Date);
            return _mapper.Map<List<EventListWm>>(allEvents);
        }
    }
}
