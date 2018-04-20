using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class CitiesController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContact = Contact.GetAll();
            return View(allContact);
        }

        [HttpGet("/cities/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("cities")]
        public ActionResult Create()
        {
          Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-street"], Request.Form["new-city"], Request.Form["new-zip"], Request.Form["new-phone"]);
          newContact.Save();
          List<Contact> allContact = Contact.GetAll();
          return View("Index", allContact);
        }

        [HttpPost("/cities/delete")]
        public ActionResult DeleteAll()
        {
            Contact.ClearAll();
            return View();
        }

    }
}
