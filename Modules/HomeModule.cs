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
      // Get["/tasks"] = _ => {
      //   List<Task> allTasks = Task.GetAll();
      //   return View["tasks.cshtml", allTasks];
      // };

    }
  }
}
