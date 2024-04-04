using System;
using System.Collections.Generic;

namespace ToDoList
{
    class programas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a sua lista: ");
            List<string> tasks = new List<string>();
            string opcao = "";

            Console.WriteLine("Sejá bem vindo ao seu to do list");

            do
            {
                Console.WriteLine("Sua agenda está aqui");
                Console.WriteLine("1. Adicionar uma tarefa na lista:");
                Console.WriteLine("2. Remover uma tarefa:");
                Console.WriteLine("3. Visualizar a lista:");
                Console.WriteLine("4. Sair do programa:");

                try
                {
                    opcao = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Opção inválida");
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite a tarefa: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("tarefa adicionada com sucesso: ");
                        break;
                    case "2":
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine(i + ": " + tasks[i]);
                        }
                        Console.WriteLine("Por favor digíte o numero da tarefa a ser removida da lista.");
                        int taskNum = Convert.ToInt32(Console.ReadLine());
                        tasks.RemoveAt(taskNum);
                        Console.WriteLine("Tarefa excuida com successo");
                        break;
                    case "3":
                        Console.WriteLine("\nLista de tarefas:");
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa");
                        break;
                    case "5":
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }
            while (opcao != "4");

            Console.WriteLine("Obrigado por ter usando a ajenda <3");
        }
    }
}