#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WefqiHobbiesWebApp.Data;
using WefqiHobbiesWebApp.Models;

namespace WefqiHobbiesWebApp.Pages.Pcs
{
    public class EditModel : PageModel
    {
        private readonly WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext _context;

        public EditModel(WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pc Pc { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pc = await _context.Pc.FirstOrDefaultAsync(m => m.ID == id);

            if (Pc == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PcExists(Pc.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PcExists(int id)
        {
            return _context.Pc.Any(e => e.ID == id);
        }
    }
}
