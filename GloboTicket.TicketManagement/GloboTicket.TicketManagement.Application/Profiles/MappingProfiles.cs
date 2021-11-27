using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Events;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event, EventListVM>().ReverseMap();
        }
    }
}
