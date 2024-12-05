using MovieTicketBooking.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieTicketBooking.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly List<Ticket> _tickets = new();

        public async Task<Ticket> BookTicketAsync(Ticket ticket)
        {
            ticket.TicketId = _tickets.Count + 1;
            _tickets.Add(ticket);
            return await Task.FromResult(ticket);
        }

        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await Task.FromResult(_tickets);
        }
    }
}
