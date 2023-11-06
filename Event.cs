public abstract class Event
{
  protected string _name;
  protected DateTime _date;
  protected string _venue;
  protected Seat[] _seats;
  protected bool[] _seatsAreFilled;
  protected List<Ticket> _bookedTickets;



  public Event(string name, DateTime date, string venue, int numberOfSeats)
  {
    _name = name;
    _date = date;
    _venue = venue;
    _seats = new Seat[numberOfSeats];
    _seatsAreFilled = new bool[numberOfSeats];
  }

  public virtual string GetEventName()
  {
    return _name;
  }

  public abstract string GetEventDetails();

  public virtual void ReserveSeat()
  {
    foreach (Ticket ticket in _bookedTickets)
    {
      Seat ticketSeat = ticket.GetTicketSeat();
      _seats[ticketSeat.GetSeatNumber()] = ticketSeat;
      _seatsAreFilled[ticketSeat.GetSeatNumber()] = true;
    }
  }

  public virtual int GetTotalAvailableSeats()
  {
    int availableSeats = 0;

    foreach (bool value in _seatsAreFilled)
    {
      if (value == false)
      {
        availableSeats++;
      }
    }

    return availableSeats;
  }

  public void BookTicket(Ticket ticket)
  {
    _bookedTickets.Add(ticket);
    ReserveSeat();
  }

  public void DisplayAllTickets()
  {
    foreach (Ticket ticket in _bookedTickets)
    {
      ticket.DisplayTicketDetails();
    }
  }

  public void DisplayAvailableSeats()
  {
    for (int index = 0; 0 < _seats.Length; index++)
    {
      if (_seatsAreFilled[index] == false)
      {
        _seats[index].GetSeatDetails();
      }
    }
  }
}
