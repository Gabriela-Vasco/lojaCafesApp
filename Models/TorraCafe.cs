namespace lojaCafesApp.Models;

public class TorraCafe
{
    public int TorraCafeId { get; set; }

    public string Nome { get; set; }

    public ICollection<Cafe> Cafes { get; set; }
}