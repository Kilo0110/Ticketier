public class Seat
{
  private int _seatNumber;
  private User _user;

  public Seat(int number, User user)
  {
    _seatNumber = number;
    _user = user;
  }

  public int GetSeatNumber()
  {
    return _seatNumber;
  }

  public string GetSeatDetails()
  {
    return $"Seat number: {_seatNumber}";
  }
}
