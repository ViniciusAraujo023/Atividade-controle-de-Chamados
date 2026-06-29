using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_e_Solicitação_de_chamados
{

    public class Menu
    {
        private ChamadoService service = new ChamadoService();
        private string senhaAdmin = "1234";

        public void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE CHAMADOS ===");
                Console.WriteLine("1 - Solicitar chamado");
                Console.WriteLine("2 - Gerenciar chamados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        SolicitarChamado();
                        break;
                    case "2":
                        GerenciarChamados();
                        break;
                    case "3":
                        return;
                }
            }
        }

        private void SolicitarChamado()
        {
            Console.Clear();

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Data de abertura (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            service.CriarChamado(matricula, nome, descricao, data);

            Console.WriteLine("Chamado criado!");
            Console.WriteLine("\nPrecione ENTER para continuar");
            Console.ReadKey();
        }

        private void GerenciarChamados()
        {
            Console.Clear();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (senha != senhaAdmin)
            {
                Console.WriteLine("Acesso negado!");
                Console.ReadKey();
                return;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== CHAMADOS ===");

                foreach (var c in service.ListarChamados())
                {
                    Console.WriteLine(c);
                    Console.WriteLine("------------------");
                }

                Console.WriteLine("1 - Concluir chamado");
                Console.WriteLine("2 - Voltar");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    if (service.ConcluirChamado(id))
                        Console.WriteLine("Concluído!");
                    else
                        Console.WriteLine("Não encontrado!");

                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
        }
    }

}
