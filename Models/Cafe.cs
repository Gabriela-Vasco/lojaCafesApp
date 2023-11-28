using System.ComponentModel.DataAnnotations;
namespace lojaCafesApp.Models;

public class Cafe 
{
    public int CafeId { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
    public string Nome { get; set; }

    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
    public string Descricao { get; set; }

    [Display(Name = "Caminho da imagem")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string ImageUri { get; set; }

    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public double Preco { get; set; }

    [Display(Name = "Entrega Expressa")]
    public bool EntregaExpressa { get; set; }

    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

    [Display(Name = "Data de Cadastro")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }

    [Display(Name = "Torra do Café")]
    public int? TorraCafeId { get; set; }
}