using lojaCafesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lojaCafesApp.Services;

namespace lojaCafesApp.Pages;

public class DetailsModel : PageModel
{
    private ICafeService _service;
    public DetailsModel(ICafeService cafeService) {
        _service = cafeService;
    }
    public Cafe Cafe { get; private set; }
    public TorraCafe TorraCafe { get; private set; }
    public IActionResult OnGet(int id)
    {
        Cafe = _service.Obter(id);
        TorraCafe = _service.ObterTodasAsTorrasDeCafe().SingleOrDefault(item => item.TorraCafeId == Cafe.TorraCafeId);

        if (Cafe == null)
        {
            return NotFound();
        }

        return Page();
    }
}
