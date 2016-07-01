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
        return View["add.html"];
      };
      Post["/contact_created"] = _ => {
        Contact c = new Contact(Request.Form["new-name"],Request.Form["new-address"],Request.Form["new-number"]);
        return View["contact_created.html"];
      };
      Post["/contacts_deleted"] = _ => {
        Contact.DeleteAllContacts();
        return View["view.html"];
      };
    }
  }
}
