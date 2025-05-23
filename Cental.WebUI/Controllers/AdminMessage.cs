
using Cental.DataAccesLayer.Context;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class AdminMessagesController : Controller
{
    private readonly CentalContext _context;

    public AdminMessagesController(CentalContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult SubmitMessage()
    {
        var messages = _context.Messages.ToList(); 
        return View(messages);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SubmitMessage(Message model)
    {
        if (ModelState.IsValid)
        {
            _context.Messages.Add(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Rezervasyonunuz başarıyla alındı!";
            return RedirectToAction("Index","Default");
        }

        return View(model);
    }
   
}
