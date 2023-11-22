using lojaCafesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lojaCafesApp.Services;

namespace lojaCafesApp.Pages;

public class CreateModel : PageModel
{
    private ICafeService _service;
    public CreateModel(ICafeService cafeService) {
        _service = cafeService;
    }

    [BindProperty]
    public Cafe Cafe { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Incluir(Cafe);
        return RedirectToPage("/Index");
    }
}