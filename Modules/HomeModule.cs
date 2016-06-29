using Nancy;
using PlacesBeen.Objects;
using System.Collections.Generic;

namespace PlacesBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      // Get["/places"] = _ => {
      //   List<Place> allPlaces = Place.GetAll();
      //   return View["places.cshtml", allPlaces];
      // };
      Get["/goForm"] = _ => {
        return View["addPlace.cshtml"];
      };
      Post["/addPlace"] = _ => {
        Place newPlace = new Place(Request.Form["city"]);
        return View["placesList.cshtml", newPlace];
      };
    }
  }
}
