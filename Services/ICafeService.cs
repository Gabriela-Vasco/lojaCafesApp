using lojaCafesApp.Models;

namespace lojaCafesApp.Services;
public interface ICafeService
{
    IList<Cafe> ObterTodos();
    Cafe Obter(int id);
    void Incluir(Cafe cafe);
    void Alterar(Cafe cafe);
    void Excluir(int id);
    IList<TorraCafe> ObterTodasAsTorrasDeCafe();
}