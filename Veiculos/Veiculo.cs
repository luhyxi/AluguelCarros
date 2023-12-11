using Common;
using VEICULO;

namespace Veiculos
{
    public class Veiculo : IVeiculo
    {
        public int IdVeiculo { get; private set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        private string Subtipo { get; set; }
        private int AnoFabricacao { get; set; }
        private int Quilometragem { get; set; }
        private Estado Estado { get; set; }
        private Cor Cor { get; set; }
        private IContrato? QuemAlugou = null;

        private string DefinirNome(string novoNome) => Nome = novoNome;
        private int MudarQuilometragem(int novaQuilometragem) => Quilometragem = novaQuilometragem;
        private Cor MudarCor(Cor novaCor) => Cor = novaCor;
        private Estado MudarEstado(Estado novoEstado) => Estado = novoEstado;

        public void MostrarInfos()
        {
            Console.WriteLine($"ID: {IdVeiculo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Subtipo: {Subtipo}");
            Console.WriteLine($"Ano de Fabricação: {AnoFabricacao}");
            Console.WriteLine($"Quilometragem: {Quilometragem}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Cliente que Alugou: {QuemAlugou.NumId}");
        }

        private static int contadorId = 0;
        private static int GerarId() => contadorId++;

        public Veiculo(string nome, Tipo tipo, string subtipo, int anoFabricacao, int quilometragem, Estado estado, Cor cor, ICliente quemAlugou)
        {
            IdVeiculo = GerarId();
            Nome = nome;
            Tipo = tipo;
            Subtipo = subtipo;
            AnoFabricacao = anoFabricacao;
            Quilometragem = quilometragem;
            Estado = estado;
            Cor = cor;
            QuemAlugou = quemAlugou.CarrosAlugados[0];
        }
    }
}
