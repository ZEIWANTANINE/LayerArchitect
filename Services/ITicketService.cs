using MovieTicketBooking.Domain;

namespace MovieTicketBooking.Services
{
    public interface ITicketService
    {
        Task<Ticket> BookTicketAsync(Ticket ticket);
        Task<List<Ticket>> GetTicketsAsync();
    }
}
