using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using HelpDeskWeb.Models;
using HelpDeskWeb.ViewModels;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using HelpDeskWeb.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HelpDeskWeb.Controllers 
{ 
 public class TicketController : Controller
{ 

    private AppDbContext appDbContext;

    public TicketController(AppDbContext dbContext)
    {
        appDbContext = dbContext;
    }

    [Authorize(Roles = "Usuario")]
    [HttpGet]
    public IActionResult MyTickets()
    {
        var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var list = _appDbContext.Tickets
            .Include(t => t.Status)
            .Include(t => t.Priority)
            .Where(t => t.CreatedById == userId)
            .OrderByDescending(t => t.CreatedAt)
            .ToList();

        return View(list);

    }

}
}