public class SportsEvent : Event
{
  private string _sportsType;
  private List<string> _participants;

  public SportsEvent(string name, string sportsType, DateTime date, string venue, int numberOfSeats, int numberOfParticipants) : base(name, date, venue, numberOfSeats)
  {
    _participants = new List<string>(numberOfParticipants);
    _sportsType = sportsType;
  }

  public override string GetEventDetails()
  {
    string participants = GetAllParticipants();

    if (_participants.Count() == 2)
    {

      return $"Event Name: {_name}\nDate: {_date}\nVenue: {_venue}\nNumber of Seats: {_seats.Length}\nSport Name: {_sportsType}\n{participants}";
    }
    else
    {
      return $"Event Name: {_name}\nDate: {_date}\nVenue: {_venue}\nNumber of Seats: {_seats.Length}\nSport Name: {_sportsType}\nParticipants of this event:\n{participants}";
    }

  }

  public void AddParticipant(string participant)
  {
    _participants.Add(participant);
  }

  public string GetAllParticipants()
  {
    if (_participants.Count() == 2)
    {
      string participantOne = _participants[0];
      string participantTwo = _participants[1];
      string eventParticipants = $"{participantOne} v {participantTwo}";

      return eventParticipants;
    }

    else
    {
      string eventParticipants = "";
      foreach (string participant in _participants)
      {
        eventParticipants = $"{eventParticipants}\n{participant}";
      }

      return eventParticipants;
    }
  }
}
