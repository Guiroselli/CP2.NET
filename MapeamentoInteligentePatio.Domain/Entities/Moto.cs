
namespace MapeamentoInteligentePatio.Domain.Entities;

public class Moto
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Status { get; set; }
    public string Localizacao { get; set; }
    public int FilialId { get; set; }
    public Filial? Filial { get; set; }

    public void MarcarManutencao()
    {
        if (Status != "Manutenção")
            Status = "Manutenção";
    }
}
