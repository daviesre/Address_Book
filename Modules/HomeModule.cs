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

      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["name"], Request.Form["phonenumber"], Request.Form["address"]);
        newContact.Save();
        return View["/contact_created.cshtml", newContact];
      };

      Get["/address_book_view"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["/address_book_view.cshtml", allContacts];
      };

      Post["/contacts_deleted"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        allContacts.Clear();
        return View["/contacts_deleted.cshtml", allContacts];
      };
    }
  }
}
