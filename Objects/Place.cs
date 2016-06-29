using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Place
  {
    private string _city;

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }
  }
}
