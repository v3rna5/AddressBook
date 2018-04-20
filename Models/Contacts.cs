using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _phone;
    // zprivate string _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string street, string city, string state, string zip, string phone)
    {
      _name = name;
      _street = street;
      _city = city;
      _state = state;
      _zip = zip;
      _phone = phone;
      _instances.Add(this);
      // _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetStreet()
    {
      return _street;
    }
    public string GetCity()
    {
      return _city;
    }
    public string GetState()
    {
      return _state;
    }
    public string GetZip()
    {
      return _zip;
    }
      public string GetPhone()
    {
      return _phone;
    }
    // public int GetId()
    // {
    //   return _id;
    // }
    public static List<Contact> GetAll()
    {
        return _instances;
    }

    public static void ClearAll()
      {
        _instances.Clear();
      }


    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }


}
  }
