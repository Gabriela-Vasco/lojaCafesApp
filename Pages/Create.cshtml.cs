using lojaCafesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lojaCafesApp.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace lojaCafesApp.Pages;

[Authorize]
public class CreateModel : PageModel
{
    private ICafeService _service;

    public SelectList TorraCafeOptionItems { get; set; }
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

    public void OnGet()
    {
        TorraCafeOptionItems = new SelectList(
                _service.ObterTodasAsTorrasDeCafe(),
                nameof(TorraCafe.TorraCafeId),
                nameof(TorraCafe.Nome)
            );
    }
}