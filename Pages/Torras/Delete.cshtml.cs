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
    public class DeleteModel : PageModel
    {
        private readonly lojaCafesApp.Data.DataContext _context;

        public DeleteModel(lojaCafesApp.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TorraCafe TorraCafe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TorraCafe == null)
            {
                return NotFound();
            }

            var torracafe = await _context.TorraCafe.FirstOrDefaultAsync(m => m.TorraCafeId == id);

            if (torracafe == null)
            {
                return NotFound();
            }
            else 
            {
                TorraCafe = torracafe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TorraCafe == null)
            {
                return NotFound();
            }
            var torracafe = await _context.TorraCafe.FindAsync(id);

            if (torracafe != null)
            {
                TorraCafe = torracafe;
                _context.TorraCafe.Remove(TorraCafe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
