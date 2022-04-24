#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WefqiHobbiesWebApp.Data;
using WefqiHobbiesWebApp.Models;

namespace WefqiHobbiesWebApp.Pages.Pcs
{
    public class DeleteModel : PageModel
    {
        private readonly WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext _context;

        public DeleteModel(WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pc = await _context.Pc.FindAsync(id);

            if (Pc != null)
            {
                _context.Pc.Remove(Pc);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
