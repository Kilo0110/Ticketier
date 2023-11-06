public class TicketReservation
{
  private List<Event> _events = new List<Event>();
  // private User _user;

  public TicketReservation()
  {

  }

  public void AddEvent(Event @event)
  {
    _events.Add(@event);
    Console.WriteLine($"Event successfully added!");

  }

  public bool CheckForEvents()
  {
    if (_events.Count == 0)
    {
      return false;
    }
    else
    {
      return true;
    }
  }

  public Event GetEvent(int eventIndex)
  {
    return _events.ElementAt(eventIndex);
  }

  public void ShowEvents()
  {
    if (CheckForEvents() == false)
    {
      Console.WriteLine($"No event has been created.");
    }
    else
    {
      Console.WriteLine($"\nAll Created Events.");

      _events.ForEach(eventItem =>
      {
        Console.WriteLine($"{_events.IndexOf(eventItem) + 1}. {eventItem.GetEventDetails()}\nAvailable Seats: {eventItem.GetTotalAvailableSeats()}\n");
      });
    }
  }

  public void RemoveEvent(int eventIndex)
  {

    Console.WriteLine($"The event \"{_events.ElementAt(eventIndex).GetEventName()}\" has been successfully deleted.");
    _events.RemoveAt(eventIndex);

  }

  public void BookTicket(Event @event, Ticket ticket)
  {

    @event.BookTicket(ticket);
  }
}
