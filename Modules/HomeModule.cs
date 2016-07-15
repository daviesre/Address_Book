using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phonenumber"], Request.Form["address"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["/contact_created", allContacts];
      };
    }
  }
}
