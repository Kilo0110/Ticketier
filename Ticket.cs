public class Ticket
{
  private Event _event;
  private Seat _seat;
  private User _user;

  public Ticket(Event @event, Seat seat, User user)
  {
    _event = @event;
    _seat = seat;
    _user = user;
  }

  public Seat GetTicketSeat()
  {
    return _seat;
  }

  public void DisplayTicketDetails()
  {
    Console.WriteLine($"\nTicket Details\nEvent Name: {_event.GetEventName()}\n{_seat.GetSeatDetails()}\nBooked for: {_user.GetUserName()}");
  }
}
