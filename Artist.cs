public class Artist
{
  private string _name;

  public Artist(string name)
  {
    _name = name;
  }

  public string GetArtist()
  {
    return $"{_name}";
  }
}
