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

      Get["/address_book_add"] = _ =>View["/address_book_add.cshtml"];

      Post["/address_book_new"] = _ => {
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phonenumber"], Request.Form["address"]);
        newContact.Save();
        List<Contact> allContacts = Contact.GetAll();
        return View["/contact_created.cshtml", allContacts];
      };
    }
  }
}
