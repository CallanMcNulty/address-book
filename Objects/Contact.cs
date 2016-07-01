using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private static List<Contact> _allContacts = new List<Contact> {};
    public Contact(string name,string address,string phoneNumber)
    {
      _name = name;
      _address = address;
      _phoneNumber = phoneNumber;
      _allContacts.Add(this);
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }
    public string GetNumber()
    {
      return _phoneNumber;
    }
    public void SetNumber(string phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }
    public static List<Contact> GetAllContacts()
    {
      return _allContacts;
    }
    public static Contact GetContactByName(string n)
    {
      foreach (Contact c in _allContacts)
      {
        if(c.GetName()==n)
        {
          return c;
        }
      }
      return _allContacts[0];
    }
    public static void DeleteAllContacts()
    {
      _allContacts = new List<Contact> {};
    }
  }
}
