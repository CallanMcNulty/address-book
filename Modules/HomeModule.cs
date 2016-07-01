using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/view"] = _ => {
        List<Contact> cList = Contact.GetAllContacts();
        foreach (Contact c in cList){Console.WriteLine(c.GetName());}//TODO-Remove
        return View["view.cshtml",cList];
      };
      Get["/add"] = _ => {
        return View["add.cshtml"];
      };
      Post["/contact_created"] = _ => {
        Contact c = new Contact(Request.Form["new-name"],Request.Form["new-address"],Request.Form["new-number"]);
        Console.WriteLine(c.GetName());//TODO-Remove
        return View["contact_created.cshtml", c];
      };
      Post["/contacts_deleted"] = _ => {
        Contact.DeleteAllContacts();
        return View["view.cshtml"];
      };
      Get["/view/{name}"] = parameters => {
        Contact c = Contact.GetContactByName(parameters.name);
        Console.WriteLine(c.GetName());//TODO-Remove
        return View["contact.cshtml", c];
      };
    }
  }
}
