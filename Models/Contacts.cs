using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _street;
    private string _city;
    private string _zip;
    private string _phone;
    private static List<Contact> _instances = new List<Contact> {};


    public Contact (string name, string street, string city, string zip, string phone)
    {
       _name = name;
      _street = street;
      _city = city;
      _zip = zip;
      _phone = phone;

    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string _newCity)
    {
      _city = _newCity;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }


    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
