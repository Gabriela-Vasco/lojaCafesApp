using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lojaCafesApp.Data;
using lojaCafesApp.Models;

namespace lojaCafesApp.Pages.Torras
{
    public class EditModel : PageModel
    {
        private readonly lojaCafesApp.Data.DataContext _context;

        public EditModel(lojaCafesApp.Data.DataContext context)
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

            var torracafe =  await _context.TorraCafe.FirstOrDefaultAsync(m => m.TorraCafeId == id);
            if (torracafe == null)
            {
                return NotFound();
            }
            TorraCafe = torracafe;
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

            _context.Attach(TorraCafe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TorraCafeExists(TorraCafe.TorraCafeId))
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

        private bool TorraCafeExists(int id)
        {
          return (_context.TorraCafe?.Any(e => e.TorraCafeId == id)).GetValueOrDefault();
        }
    }
}
