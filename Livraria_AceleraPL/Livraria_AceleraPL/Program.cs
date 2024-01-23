using Livraria;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria_AceleraPL
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            List<Livros> biblioteca = new List<Livros>();
            List<Usuario> usuarios = new List<Usuario>();
            List<Emprestimo> emprestimos = new List<Emprestimo>();

            do
            {
                opcao = ExibirMenu();

                switch (opcao)
                {
                    case 1:
                        CadastrarLivro(biblioteca);
                        break;
                    case 2:
                        Console.WriteLine("Cadastro de Usuario");
                        CadastrarUsuario(usuarios);
                        break;
                    case 3:
                        Console.WriteLine("Consultar Livros");
                        NovoEmprestimo(biblioteca, usuarios, emprestimos);
                        break;
                    case 4:
                        Console.WriteLine("Devolver Empréstimo");
                        break;
                    case 5:
                        Console.WriteLine("Consultar Livros");
                        ConsultarLivros(biblioteca);
                        break;
                }
            } while (opcao != 7);

            Console.ReadLine();
        }

        static int ExibirMenu()
        {
            Console.WriteLine("O QUE VOCE DESEJA?");
            Console.WriteLine("========CADASTROS========");
            Console.WriteLine("1 - CADASTRAR LIVRO");
            Console.WriteLine("2 - CADASTRAR USUARIO");

            Console.WriteLine("========TRANSAÇÕES=======");
            Console.WriteLine("3 - NOVO EMPRÉSTIMO");
            Console.WriteLine("4 - DEVOLVER EMPRÉSTIMO");

            Console.WriteLine("========CONSULTAS========");
            Console.WriteLine("5 - CONSULTAR LIVROS");
            Console.WriteLine("6 - CONSULTAR USUARIO");

            Console.WriteLine("======CONFIGURAÇÕES======");
            Console.WriteLine("7 - SAIR");
            Console.WriteLine("=========================");

            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                return opcao;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                return ExibirMenu();
            }
        }

        static void CadastrarLivro(List<Livros> biblioteca)
        {
            Console.WriteLine("Cadastro de Livro");

            Console.Write("Nome do Livro: ");
            string livro = Console.ReadLine();
            Console.Write("Codigo: ");

            if (double.TryParse(Console.ReadLine(), out double cod))
            {
                // Verifique se o código é único antes de adicionar
                if (biblioteca.Any(l => l.Codigo == cod))
                {
                    Console.WriteLine("Código já cadastrado. Tente novamente com um código único.");
                    return;
                }

                Console.Write("Valor: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal valor))
                {
                    Console.Write("Nº Paginas: ");
                    if (int.TryParse(Console.ReadLine(), out int pg))
                    {
                        Livros novo = new Livros(livro, pg, cod, valor);
                        biblioteca.Add(novo);
                    }
                    else
                    {
                        Console.WriteLine("Número de páginas inválido. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
            }
        }

        static void NovoEmprestimo(
            List<Livros> biblioteca,
            List<Usuario> usuarios,
            List<Emprestimo> emprestimos
        )
        {
            Console.Write("Login: ");
            string login = Console.ReadLine();

            Usuario buscado = usuarios.FirstOrDefault(x => x.Login.Equals(login));

            if (buscado != null)
            {
                Console.WriteLine("Usuario Encontrado...");

                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                if (buscado.Senha == senha)
                {
                    Console.WriteLine("Usuario Logado!");
                    Console.WriteLine("");
                    Console.Write("Qual livro você deseja?, digite o nome: ");
                    string nomeLivro = Console.ReadLine();

                    List<Livros> buscalivro = biblioteca
                        .Where(x => x.Livro.StartsWith(nomeLivro))
                        .ToList();
                    if (buscalivro.Count == 0)
                    {
                        Console.WriteLine("Livro não encontrado");
                    }
                    else if (buscalivro.Count == 1)
                    {
                        Console.WriteLine($"{buscalivro[0].Livro} encontrado!");

                        // ADICIONA "REGISTRO" NA LISTA EMPRESTIMOS (OPICIONAL)
                        Emprestimo novoEmprestimo = new Emprestimo(buscalivro[0], buscado);
                        emprestimos.Add(novoEmprestimo);
                    }
                    else
                    {
                        Console.WriteLine($"{buscalivro.Count} encontrados");

                        // INFORMAR QUAIS LIVROS ENCONTRADOS COM O NOME
                        Console.WriteLine("Livros encontrados:");
                        foreach (var livroEncontrado in buscalivro)
                        {
                            Console.WriteLine(
                                $"{livroEncontrado.Livro} - Código: {livroEncontrado.Codigo}"
                            );
                        }

                        Console.Write("Digite o código do livro desejado: ");
                        if (double.TryParse(Console.ReadLine(), out double codigoLivroEscolhido))
                        {
                            Livros livroEscolhido = buscalivro.FirstOrDefault(
                                l => l.Codigo == codigoLivroEscolhido
                            );
                            if (livroEscolhido != null)
                            {
                                Emprestimo novoEmprestimo = new Emprestimo(livroEscolhido, buscado);
                                emprestimos.Add(novoEmprestimo);
                            }
                            else
                            {
                                Console.WriteLine("Código do livro inválido. Operação cancelada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Código do livro inválido. Operação cancelada.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Senha Incorreta");
                }
            }
            else
            {
                Console.WriteLine("Usuario não Encontrado...");
            }
        }

        static void CadastrarUsuario(List<Usuario> usuarios)
        {
            Console.Write("Nome do Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            Usuario novoUser = new Usuario(usuario, login, senha);
            usuarios.Add(novoUser);

            Console.WriteLine($"Usuário {novoUser.Nome} cadastrado com sucesso. ID: {novoUser.Id}");
        }

        static void ConsultarLivros(List<Livros> biblioteca)
        {
            int i = 0;
            foreach (var liv in biblioteca)
            {
                Console.WriteLine($"Item {i}");
                Console.WriteLine($"Nome: {liv.Livro}");
                Console.WriteLine($"Código: {liv.Codigo}");
                Console.WriteLine($"Valor: {liv.Valor:C}");
                Console.WriteLine();
                i++;
            }
        }
    }
}