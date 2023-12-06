using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lojaCafesApp.Data;
using lojaCafesApp.Models;

namespace lojaCafesApp.Pages.Torras
{
    public class CreateModel : PageModel
    {
        private readonly lojaCafesApp.Data.DataContext _context;

        public CreateModel(lojaCafesApp.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TorraCafe TorraCafe { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.TorraCafe == null || TorraCafe == null)
            {
                return Page();
            }

            _context.TorraCafe.Add(TorraCafe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
