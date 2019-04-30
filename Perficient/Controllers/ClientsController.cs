using Perficient.Models;
using Perficient.ViewModels;
using System;
using System.Web.Mvc;

namespace Perficient.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(ClientViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Register", viewModel);

            var client = new Client
            {
                Name = viewModel.Name,
                Street = viewModel.Street,
                City = viewModel.City,
                State = viewModel.State,
                ZipCode = viewModel.ZipCode,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                DateTime = DateTime.Now
            };

            _context.Clients.Add(client);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}