using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
//Set strings
    private string _name;
    private string _phoneNumber;
    private string _address;
    private static List<Book> _instances = new List<Book> {};
//Constructor
    public Book (string name, string phone, string address)
    {
      _name = name;
      _phoneNumber = phone;
      _address = address;
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

    public void SetAddress(string address)
    {
      _address = newAddress;
    }
  }
}
