using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class InfoController : Controller
  {
    [HttpGet("/addressbook")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/addressbook")]
    public ActionResult Create()
    {
      Contact newTamagotchi = new Contact (Request.Form["new-name", "new-street", "new-city", "new-state", "new-zip", "new-phone"]);

      List<Contact> allContacts = Contact.GetAll();
      return View("Index", allContacts);
    

        }
        [HttpPost("/addressbook/clear")]
        public ActionResult DeleteAll()
        {
            Contact.ClearAll();
            return View();
        }
  }
}
