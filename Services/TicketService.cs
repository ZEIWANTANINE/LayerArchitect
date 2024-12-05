using MovieTicketBooking.Domain;
using MovieTicketBooking.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketBooking.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<Ticket> BookTicketAsync(Ticket ticket)
        {
            if (string.IsNullOrWhiteSpace(ticket.MovieName) || ticket.SeatNumber <= 0)
            {
                throw new ArgumentException("Invalid ticket details.");
            }

            return await _ticketRepository.BookTicketAsync(ticket);
        }

        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await _ticketRepository.GetTicketsAsync();
        }
    }
}
