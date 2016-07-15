using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
//Set strings
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private string _phoneNumber;
    private string _address;
//Constructor
    public Contact (string newname, string newphone, string newaddress)
    {
      _name = newname;
      _phoneNumber = newphone;
      _address = newaddress;
    }
//Getters and Setters
    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
// Save
    public void Save()
    {
      _instances.Add(this);
    }
// Remove
    public static void DeleteAll()
    {
      _instances.Clear();
    }
  }
}
