public class Concert : Event
{
  private List<Artist> _artists = new List<Artist>();

  public Concert(string name, DateTime date, string venue, int numberOfSeats) : base(name, date, venue, numberOfSeats)
  {

  }

  public void AddArtist(string artistName)
  {
    Artist artist = new Artist(artistName);

    _artists.Add(artist);
  }

  public override string GetEventDetails()
  {
    string artistNames = string.Join(", ", _artists.Select(artist => artist.GetArtist()));
    return $"Event Name: {_name}\nDate: {_date}\nVenue: {_venue}\nNumber of Seats: {_seats.Length}\nArtists: {artistNames}";
  }
}
