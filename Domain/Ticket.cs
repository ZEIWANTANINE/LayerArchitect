namespace MovieTicketBooking.Domain;

public class Ticket
{
    public int TicketId { get; set; }
    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public int SeatNumber { get; set; }
    public DateTime ShowTime { get; set; }
    public decimal Price { get; set; }
}
