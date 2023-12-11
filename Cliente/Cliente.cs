using Common;
using System;
using System.Collections.Generic;

namespace Usuarios
{
    public class Cliente : Pessoa
    {
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<string> nomeClientes = new List<string>();
        public static List<string> idClientes = new List<string>();
        public bool EstaAlugando { get; set; }
        public int QuantidadeAlugados { get; set; }

        private IContrato[] Contratos;

        public IContrato[] CarrosAlugados { get; set; }

        public Cliente(string nome) : base(nome)
        {
            EstaAlugando = false;
            QuantidadeAlugados = 0;
            Contratos = new IContrato[QuantidadeAlugados];

        }

        public void CriarCliente()
        {
            Console.WriteLine("Insira o nome do cliente:");
            string nome = Console.ReadLine();
            Cliente clienteNovo = new Cliente(nome);
            Clientes.Add(clienteNovo);
            nomeClientes.Add(nome);
            idClientes.Add(clienteNovo.IdPessoa.ToString());
        }
    }
}
