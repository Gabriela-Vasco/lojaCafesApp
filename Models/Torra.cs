namespace lojaCafesApp.Models;

public class Torra
{
    public int TorraId { get; set; }

    public string Nome { get; set; }
    public string Características { get; set; }

    public IList<Cafe> Cafes { get; set; }
}