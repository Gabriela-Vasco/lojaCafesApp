using lojaCafesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lojaCafesApp.Services;

namespace lojaCafesApp.Pages;

public class EditModel : PageModel
{
    private ICafeService _service;
    public EditModel(ICafeService cafeService) {
        _service = cafeService;
    }

    [BindProperty]
    public Cafe Cafe { get; set; }

    public void OnGet(int id) => Cafe = _service.Obter(id);

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Alterar(Cafe);
        return RedirectToPage("/Index");
    }
    
    public IActionResult OnPostDelete()
    {
        _service.Excluir(Cafe.CafeId);
        return RedirectToPage("/Index");
    }
}