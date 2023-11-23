using lojaCafesApp.Models;
using lojaCafesApp.Pages;
using WebApi.Helpers;

namespace lojaCafesApp.Services.Data;

public class CafeService : ICafeService
{
    private DataContext _context;
    public CafeService(DataContext context)
    {
        _context = context;
    }
    public void Alterar(Cafe cafe)
    {
        var cafeEncontrado = Obter(cafe.CafeId);
        cafeEncontrado.Nome = cafe.Nome;
        cafeEncontrado.Descricao = cafe.Descricao;
        cafeEncontrado.ImageUri = cafe.ImageUri;
        cafeEncontrado.Preco = cafe.Preco;
        cafeEncontrado.EntregaExpressa = cafe.EntregaExpressa;
        cafeEncontrado.DataCadastro = cafe.DataCadastro;
        
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var cafeEncontrado = Obter(id);
        _context.Cafe.Remove(cafeEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Cafe cafe)
    {
        _context.Cafe.Add(cafe);
        _context.SaveChanges();
    }

    public Cafe Obter(int id)
    {
        return _context.Cafe.SingleOrDefault(item => item.CafeId == id);
    }

    public IList<Cafe> ObterTodos()
    {
        return _context.Cafe.ToList();
    }

    public IList<TorraCafe> ObterTodasAsTorrasDeCafe()
    {
        return _context.TorraCafe.ToList();
    }
}