using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using HelpDeskWeb.Models;
using HelpDeskWeb.ViewModels;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using HelpDeskWeb.Data;

namespace HelpDeskWeb.Controllers
{
    public class TicketPriorityController : Controller
    {
        AppDbContext _appDbContext;

        public TicketPriorityController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<TicketPriority> TicketPriorityList = _appDbContext.TicketPriority.ToList();
            return View(TicketPriorityList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketPriority ticketpriority)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.TicketPriority.Add(ticketpriority);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketpriority);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ticketpriority = _appDbContext.TicketPriority.Find(id);
            if (ticketpriority == null)
            {
                return NotFound();
            }
            return View(ticketpriority);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TicketPriority ticketpriority)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.TicketPriority.Update(ticketpriority);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketpriority);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var ticketpriority = _appDbContext.TicketPriority.Find(id);
            if (ticketpriority == null)
            {
                return NotFound();
            }
            _appDbContext.TicketPriority.Remove(ticketpriority);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}