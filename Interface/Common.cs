using VEICULO;

namespace Common
{
    public interface IContrato
    {
        int NumId { get; }
        ICliente Contratante { get; set; }
        IVeiculo CarroContratado { get; set; }
        int Valor { get; set; }

        void DefinirValor(int novoValor);
        void GerarContrato(ICliente contratante, IVeiculo carroContratado);
    }

    public interface ICliente
    {
        string Nome { get; set; }
        bool EstaAlugando { get; set; }
        int QuantidadeAlugados { get; set; }
        IContrato[] CarrosAlugados { get; set; }
    }

    public interface IVeiculo
    {
        int IdVeiculo { get; }
        string Nome { get; set; }
        Tipo Tipo { get; set; }
        void MostrarInfos();
    }
}
