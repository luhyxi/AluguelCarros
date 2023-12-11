using Common;
using SETOR;
using VEICULO;
using Veiculos;

// TODO: INSERIR LOGICA DE SETORES PARA CADA FUNCIONARIO

namespace Usuarios
{
    public class Funcionario : Pessoa
    {
        public static List<Funcionario> Funcionarios = new List<Funcionario>();
        public static List<string> nomeFuncionarios = new List<string>();
        public static List<string> idFuncionarios = new List<string>();


        public Setor setor { get; set; }
        private int salario { get; set; }
        private bool statuEstaAtivo{ get; set; }
        private DateTime dataContratacao { get; set; }
        private DateTime dataDemissao{ get; set; }
        public Funcionario(string nome) : base(nome)
        {

        }
        public static void CriarFuncionario() 
        {
            Console.WriteLine("Insira seu nome");
            string nome = Console.ReadLine();
            Funcionario funcionarioNovo = new Funcionario(nome);
            funcionarioNovo.Contratar();
            Funcionarios.Add(funcionarioNovo);
            nomeFuncionarios.Add(nome);
            idFuncionarios.Add(funcionarioNovo.IdPessoa.ToString());
        }

        public void MostrarInfosFuncionario()
        {
            Console.WriteLine($"Nome do Funcionario: {nome}");
            Console.WriteLine($"ID do Funcionario: {IdPessoa}");
        }

        public void MudarSetor(Setor novoSetor) => setor = novoSetor;
        public void MudarSalario(int novoSalario) => salario = novoSalario;
        public void MudarStatus(bool novoStatus) => statuEstaAtivo = novoStatus;
        public void Contratar() 
        { 
            dataContratacao = DateTime.Now;
            MudarStatus(true);
        }
        public void Demitir()
        {
            dataContratacao = DateTime.Now;
            MudarStatus(false);
        }
        public void AdicionarVeiculo()
        {
            string nome, subtipo;
            int anoFabricacao, quilometragem;
            Tipo tipo;
            Estado estado;
            Cor cor;
            ICliente cliente;

            do
            {
                Console.WriteLine("Insira o nome do carro:");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    nome = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Nome inválido. Por favor, insira um nome válido.");
                }
            } while (true);

            Console.WriteLine("Insira o subtipo do veículo:");
            subtipo = Console.ReadLine();

            Console.WriteLine("Insira o ano de fabricação:");
            while (!int.TryParse(Console.ReadLine(), out anoFabricacao) || anoFabricacao <= 0)
            {
                Console.WriteLine("Ano de fabricação inválido. Por favor, insira um ano válido.");
            }

            Console.WriteLine("Insira a quilometragem:");
            while (!int.TryParse(Console.ReadLine(), out quilometragem) || quilometragem < 0)
            {
                Console.WriteLine("Quilometragem inválida. Por favor, insira um valor válido.");
            }
            Console.WriteLine("Insira o estado do veículo (Carro, Moto, Caminhao, Van, Bicicleta, Outro):");
            while (!Enum.TryParse(Console.ReadLine(), out tipo))
            {
                Console.WriteLine("Tipo inválido. Por favor, insira um tipo válido.");
            }

            Console.WriteLine("Insira o estado do veículo (Disponivel, Alugado, Manutenção, Indisponivel):");
            while (!Enum.TryParse(Console.ReadLine(), out estado))
            {
                Console.WriteLine("Estado inválido. Por favor, insira um estado válido.");
            }

            Console.WriteLine("Insira a cor do veículo (Preto, Branco, Cinza, Vermelho):");
            while (!Enum.TryParse(Console.ReadLine(), out cor))
            {
                Console.WriteLine("Cor inválida. Por favor, insira uma cor válida.");
            }

            Veiculo veiculo = new Veiculo(nome, tipo, subtipo, anoFabricacao, quilometragem, estado, cor, null);
        }

    }
}
