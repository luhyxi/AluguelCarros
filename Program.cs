using System;
using System.Collections.Generic;

namespace Usuarios
{
    class Program
    {
        static string nomePessoaAtual = null;

        static void Main()
        {
            SistemaPrincipal();
        }

        static void SistemaPrincipal()
        {
            Console.WriteLine(
                @$"Olá, bem-vindo ao sistema de Aluguel de Carros! Escolha seu acesso
1 - Cliente
2 - Funcionario");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    SistemaCliente();
                    break;
                case "2":
                    SistemaFuncionario();
                    break;
            }
        }

        static void SistemaCliente()
        {
            Console.Clear();
            VerificacaoEntidade(Cliente.nomeClientes, Cliente.idClientes, "Cliente");
            Console.WriteLine("Bem vindo ao sistema");
        }

        static void SistemaFuncionario()
        {
            Console.Clear();
            VerificacaoEntidade(Funcionario.nomeFuncionarios, Funcionario.idFuncionarios, "Funcionario");
            Funcionario funcionarioAtual = IdentificarFuncionario(Funcionario.Funcionarios, nomePessoaAtual);
            Console.WriteLine($"Olá funcionario {funcionarioAtual?.nome}");
        }

        static void VerificacaoEntidade(List<string> nomes, List<string> ids, string entidadeNome)
        {
            Console.Clear();
            if (nomes.Count > 0)
            {
                Console.WriteLine($"Por favor insira o nome do {entidadeNome}");
                string input = Console.ReadLine();
                while (!nomes.Contains(input) && !ids.Contains(input))
                {
                    Console.WriteLine($"Essa {entidadeNome} não existe. Por favor, insira um nome válido.");
                    input = Console.ReadLine();
                }
                nomePessoaAtual = input;
            }
            else
            {
                Console.WriteLine($"Nenhum {entidadeNome.ToLower()} encontrado, por favor crie o seu Login");
                Console.ReadKey();
                Console.Clear();
                Funcionario.CriarFuncionario();
            }
            Console.Clear();
        }

        static Funcionario IdentificarFuncionario(List<Funcionario> listaFuncionarios, string nomePesquisado)
        {
            return listaFuncionarios.Find(f => f.nome == nomePesquisado);
        }

        static Cliente IdentificarCliente(List<Cliente> listaCliente, string nomePesquisado)
        {
            return listaCliente.Find(c => c.nome == nomePesquisado);
        }
    }
}
