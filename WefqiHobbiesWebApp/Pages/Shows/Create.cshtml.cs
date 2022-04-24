#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WefqiHobbiesWebApp.Data;
using WefqiHobbiesWebApp.Models;

namespace WefqiHobbiesWebApp.Pages.Shows
{
    public class CreateModel : PageModel
    {
        private readonly WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext _context;

        public CreateModel(WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Show Show { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Show.Add(Show);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
