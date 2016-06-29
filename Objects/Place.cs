using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Place
  {
    private string _city;

    public Place (string city)
    {
      _city = city;
      // _instances.Add(this);
      // _id = _instances.Count;
    }

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
