
using System;
namespace Aula_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Qual operação você desejá realizar" + Environment.NewLine +
                        "1- Adicionar Tarefa" + Environment.NewLine +
                        "2- Remover tarefa" + Environment.NewLine +
                        "3- Atualizar tarefa" + Environment.NewLine +
                        "4- Listar todas as tarefas" + Environment.NewLine
                        + "5- Apresentar uma tarefa através do seu index");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Todo.AdicionarTarefa();

                }
                else if (opcao == 2)
                {
                    Todo.RemoverTarefa();
                }
                else if (opcao == 3) { Todo.AtualizarTarefa(); }
                else if (opcao == 4) { Todo.ListarTodasAsTarefas(); }
                else
                {
                    Todo.ApresentarTarefaAtravesdoindex();
                };
            }

            while (i < 0);
            {
                Console.WriteLine("Qual operação você desejá realizar" + Environment.NewLine +
                    "1- Adicionar Tarefa" + Environment.NewLine +
                    "2- Remover tarefa" + Environment.NewLine +
                    "3- Atualizar tarefa" + Environment.NewLine +
                    "4- Listar todas as tarefas" + Environment.NewLine
                    + "5- Apresentar uma tarefa através do seu index");

                int opcao = int.Parse(Console.ReadLine());

            
            



                if (opcao == 1)
                {
                     Todo.AdicionarTarefa();

                }
                else if (opcao == 2)
                {
                    Todo.RemoverTarefa();
                }
                else if (opcao == 3) { Todo.AtualizarTarefa(); }
                else if (opcao == 4) { Todo.ListarTodasAsTarefas(); }
                else
                {
                    Todo.ApresentarTarefaAtravesdoindex();
                
                };
                i++;

            }
         
        }
    }
}

            


        
    
