
namespace MapeamentoInteligentePatio.Domain.Entities;

public class Filial
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public ICollection<Moto>? Motos { get; set; }
}
