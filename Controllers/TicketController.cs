using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Domain;
using MovieTicketBooking.Services;
using System.Threading.Tasks;

namespace MovieTicketBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost("book")]
        public async Task<IActionResult> BookTicket([FromBody] Ticket ticket)
        {
            try
            {
                var bookedTicket = await _ticketService.BookTicketAsync(ticket);
                return Ok(bookedTicket);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllTickets()
        {
            var tickets = await _ticketService.GetTicketsAsync();
            return Ok(tickets);
        }
    }
}
