using Atividade_POO_SOLID.Interfaces;
using Atividade_POO_SOLID.Models;
using Atividade_POO_SOLID.Repositories;
using Atividade_POO_SOLID.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Atividade_POO_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Pessoas (Aluno/Funcionário)\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\t1 - Adicionar");
            Console.WriteLine("\t2 - Alterar");
            Console.WriteLine("\t3 - Remover");
            Console.WriteLine("\t4 - Listar");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarPessoa();
                    break;
                case "2":
                    Console.WriteLine("############## - Não Implementado - ##############");
                    Console.WriteLine("Aperte alguma tecla para chamar menu");
                    Console.ReadLine();
                    Menu();
                    break;
                case "3":
                    Remover();
                    break;
                case "4":
                    Listar();
                    Console.WriteLine("Aperte alguma tecla para chamar menu");
                    Console.ReadLine();
                    Menu();
                    break;
            }
            Console.ReadLine();
        }

        private static void Remover()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var pessoaRepository = serviceProvider.GetService<IPessoaRepository>();

            Console.WriteLine("Informe o Id para remover:");
            Listar();
            int id = int.Parse(Console.ReadLine());
            //REMOVER
            pessoaRepository.Remover(id);
            //REMOVER
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Id " + id + " removido com sucesso");
            Listar();
            Console.WriteLine("Aperte alguma tecla para chamar menu");
            Console.ReadLine();
            Menu();
        }

        private static void Listar()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var pessoaRepository = serviceProvider.GetService<IPessoaRepository>();

            //LISTAR
            var lista = pessoaRepository.Listar();
            //LISTAR
            foreach (var item in lista)
            {
                Console.WriteLine("\nInformações: " + item.IdNomeEmail());
                Console.WriteLine("------------------------\n");
            }
        }

        private static void AdicionarPessoa()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var pessoaRepository = serviceProvider.GetService<IPessoaRepository>();

            Console.WriteLine("------------------------\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\t1 - Aluno");
            Console.WriteLine("\t2 - Funcionário");
            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarAluno(pessoaRepository, new Aluno());//IMPLEMENTAÇÃO
                    break;
                case "2":
                    AdicionarFuncionario(pessoaRepository, new Funcionario());//IMPLEMENTAÇÃO
                    break;
            }
            Menu();
        }

        private static void AdicionarFuncionario(IPessoaRepository pessoaRepository, Funcionario funcionario)
        {
            //ADD DADOS PESSOA
            Console.WriteLine("\tInforme os dados pessoais");
            Console.WriteLine("Informe o Nome:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Email:");
            funcionario.Email = Console.ReadLine();
            //ADD DADOS PESSOA

            ////ADD DADOS FUNCIONARIO
            Console.WriteLine("\tInforme os dados funcionário");
            Console.WriteLine("Informe o Cargo:");
            funcionario.Cargo = Console.ReadLine();
            Console.WriteLine("Informe o Data Admissão:");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
            //ADD DADOS FUNCIONARIO

            //ADD FUNCIONARIO
            pessoaRepository.Adicionar(funcionario);

            Console.WriteLine("Dados cadastrados com sucesso:" +
                "\nFuncionário:" + funcionario.Nome.ToUpper() +
                "\ntCargo:" + funcionario.Cargo.ToUpper());
            //ADD FUNCIONARIO
            Menu();
        }

        private static void AdicionarAluno(IPessoaRepository pessoaRepository, Aluno aluno)
        {
            //ADD DADOS PESSOA
            Console.WriteLine("\tInforme os dados pessoais");
            Console.WriteLine("Informe o Nome:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Email:");
            aluno.Email = Console.ReadLine();
            //ADD DADOS PESSOA

            ////ADD DADOS ALUNO
            Console.WriteLine("\tInforme os dados funcionário");
            Console.WriteLine("Informe o Curso:");
            aluno.Curso = Console.ReadLine();
            Console.WriteLine("Informe o Data Matrícula:");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine());
            //ADD DADOS ALUNO

            //ADD ALUNO
            pessoaRepository.Adicionar(aluno);
            //ADD ALUNO

            Console.WriteLine("Dados cadastrados com sucesso:" +
                "\nAluno:" + aluno.Nome.ToUpper() +
                "\nCurso:" + aluno.Curso.ToUpper());
            Menu();
        }

        private static void ConfigureServices(IServiceCollection services)//Princípio da inversão da dependência
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
        }
    }
}
