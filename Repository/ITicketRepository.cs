using MovieTicketBooking.Domain;

namespace MovieTicketBooking.Repository
{
    public interface ITicketRepository
    {
        Task<Ticket> BookTicketAsync(Ticket ticket);
        Task<List<Ticket>> GetTicketsAsync();
    }
}
