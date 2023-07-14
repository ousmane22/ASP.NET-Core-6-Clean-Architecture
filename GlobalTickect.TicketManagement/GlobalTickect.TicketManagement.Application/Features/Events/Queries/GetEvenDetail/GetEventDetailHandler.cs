using AutoMapper;
using GlobalTickect.TicketManagement.Application.Contracts.Persistence;
using GlobalTickect.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Application.Features.Events.Queries.GetEvenDetail
{
    public class GetEventDetailHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;


        public GetEventDetailHandler(IMapper mapper, IAsyncRepository<Event> eventRepository,
            IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;

        }

        public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var ev = await _eventRepository.GetByIdAsync(request.Id);
            var evenDto = _mapper.Map<EventDetailVm>(ev);

            var category = await _categoryRepository.GetByIdAsync(evenDto.CategorieId);
            evenDto.Category = _mapper.Map<CategoryDto>(category);

            return evenDto;
        }
    }
}
