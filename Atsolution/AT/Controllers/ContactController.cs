using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AT.Efs.Entities;
using AT.Models;
using Microsoft.AspNetCore.Mvc;

namespace AT.Controllers
{
    public class ContactController : GsControllerBase<ContactController>
    {
        public ContactController(WebAtSolutionContext webContext) : base(webContext)
        {

        }

        [HttpGet("lien-he")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> NewContact([FromForm]ContactViewModel model)
        {
            try
            {
                Contact contact = new Contact();
                contact.Id = Guid.NewGuid().ToString();
                contact.Name = model.Name;
                contact.Email = model.Email;
                contact.Phone = model.Phone;
                contact.Title = model.Title;
                contact.Body = model.Body;
                contact.IsRead = false;
                contact.Note = "Note";
                contact.CreatedBy = "CreatedBy";
                contact.CreatedDate = DateTime.Now;
                contact.RowStatus = 0;

                _webContext.Contact.Add(contact);
                await _webContext.SaveChangesAsync();

                return RedirectToAction(nameof(ContactController.Index), nameof(ContactController).Replace("Controller", ""));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}