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
    public class IndexModel : PageModel
    {
        private readonly WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext _context;

        public IndexModel(WefqiHobbiesWebApp.Data.WefqiHobbiesWebAppContext context)
        {
            _context = context;
        }

        public IList<Pc> Pc { get;set; }

        public async Task OnGetAsync()
        {
            Pc = await _context.Pc.ToListAsync();
        }
    }
}
