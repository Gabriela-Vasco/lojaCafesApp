using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lojaCafesApp.Data;
using lojaCafesApp.Models;

namespace lojaCafesApp.Pages.Torras
{
    public class IndexModel : PageModel
    {
        private readonly lojaCafesApp.Data.DataContext _context;

        public IndexModel(lojaCafesApp.Data.DataContext context)
        {
            _context = context;
        }

        public IList<TorraCafe> TorraCafe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TorraCafe != null)
            {
                TorraCafe = await _context.TorraCafe.ToListAsync();
            }
        }
    }
}
