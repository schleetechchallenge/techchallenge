using Perficient.Models;
using Perficient.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Perficient.Controllers
{
    public class AttendeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttendeesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Register()
        {
            var viewModel = new AttendeeViewModel
            {
                Clients = _context.Clients.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Register(AttendeeViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Clients = _context.Clients.ToList();
                return View("Register", viewModel);
            }

            var client = _context.Clients.Single(c => c.Id == viewModel.Client);

            var attendee = new Attendee
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                DateTime = DateTime.Now,
                Client = client
            };

            _context.Attendees.Add(attendee);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Attendees()
        {
            return View();
        }
    }
}