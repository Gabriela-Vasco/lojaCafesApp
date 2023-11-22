using lojaCafesApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lojaCafesApp.Services;

namespace lojaCafesApp.Pages;

public class IndexModel : PageModel
{

    private ICafeService _service;
    public IndexModel(ICafeService cafeService) {
        _service = cafeService;
    }

    public IList<Cafe> ListaCafes { get; private set; }
    public void OnGet()
    {
        ViewData["Title"] = "Home page";

        ListaCafes = _service.ObterTodos();
    }
}
