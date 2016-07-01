using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.html"];
      };
      Get["/view"] = _ => {
        return View["view.html"];
      };
      Get["/add"] = _ => {
        return View["add.html"]
      };
    }
  }
}
