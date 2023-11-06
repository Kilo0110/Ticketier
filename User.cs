public class User
{
  private string _firstName;
  private string _lastName;
  private int _age;
  private List<Ticket> _tickets = new List<Ticket>();

  public User(string firstName, string lastName, int age)
  {
    _firstName = firstName;
    _lastName = lastName;
    _age = age;
  }

  public string GetUserDetails()
  {
    return $"First Name: {_firstName}\nLast Name: {_lastName}\nAge: {_age}";
  }

  public string GetUserName()
  {
    return $"{_lastName} {_firstName}";
  }

  public void AddNewTicket(Ticket ticket)
  {
    _tickets.Add(ticket);
  }

  public void DisplayTickets()
  {
    _tickets.ForEach(ticket =>
    {
      ticket.DisplayTicketDetails();
    });
  }
}
