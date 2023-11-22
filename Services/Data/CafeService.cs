using lojaCafesApp.Models;
using lojaCafesApp.Pages;
using WebApi.Helpers;

namespace lojaCafesApp.Services.Data;

public class CafeService : ICafeService
{
    private DataContext _context;
    public CafeService(DataContext context)
    {
        context = _context;
    }
    public void Alterar(Cafe cafe)
    {
        throw new NotImplementedException();
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public void Incluir(Cafe cafe)
    {
        throw new NotImplementedException();
    }

    public Cafe Obter(int id)
    {
        return _context.Cafe.SingleOrDefault(item => item.CafeId == id);
    }

    public IList<Cafe> ObterTodos()
    {
        return _context.Cafe.ToList();
    }
}