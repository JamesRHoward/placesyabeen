using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Place
  {
    private string _city;
    private string _yearLastVisited;
    private string _adjective;
    private string _imageLink;

    private static List<Place> _instances = new List<Place> {};

    public Place (string city, string yearLastVisited, string adjective, string imgLink)
    {
      _city = city;
      _yearLastVisited = yearLastVisited;
      _adjective = adjective;
      _imageLink = imgLink;
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
    public string GetYear()
    {
      return _yearLastVisited;
    }

    public void SetYear(string newYear)
    {
      _yearLastVisited = newYear;
    }
    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
    public string GetImageLink()
    {
      return _imageLink;
    }

    public void SetImageLink(string newLink)
    {
      _imageLink = newLink;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

  }
}
