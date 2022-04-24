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

namespace WefqiHobbiesWebApp.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext _context;

        public DetailsModel(WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
