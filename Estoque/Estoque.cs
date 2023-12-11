using Veiculos;

namespace Estoque
{
    public class Estoque
    {
        List<Veiculo> veiculosEstoque = new List<Veiculo>();

        public void MostrarEstoque() 
        {
            foreach (var veiculo in veiculosEstoque)
            {
                Console.WriteLine($@"ID: {veiculo.IdVeiculo}, Nome: {veiculo.Nome}");
            }
        }
    }
}
