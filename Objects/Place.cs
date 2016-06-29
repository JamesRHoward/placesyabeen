using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Place
  {
    private string _city;

    private static List<Place> _instances = new List<Place> {};

    public Place (string city)
    {
      _city = city;
      _instances.Add(this);
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

    public static List<Place> GetAll()
    {
      return _instances;
    }

  }
}
