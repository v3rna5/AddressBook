using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class InfoController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContact = Contact.GetAll();
            return View(allContact);
        }

        [HttpGet("/info/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("info")]
        public ActionResult Create()
        {
          Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-street"], Request.Form["new-city"], Request.Form["new-zip"], Request.Form["new-phone"]);
          newContact.Save();
          List<Contact> allContact = Contact.GetAll();
          return View("Index", allContact);
        }

        [HttpPost("/info/delete")]
        public ActionResult DeleteAll()
        {
            Contact.ClearAll();
            return View();
        }
      }
    }
