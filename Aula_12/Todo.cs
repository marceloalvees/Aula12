using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12
{
    internal class Todo
    {
       List<String> Tarefas = new List<String>();
        public void AdicionarTarefa() {
            Console.WriteLine("Adicione uma tarefa: ");
            Tarefas.Add(Console.ReadLine());
        }
        public void RemoverTarefa() {
            Console.WriteLine("Qual tarefa deseja remover: ");
            Tarefas.Remove(Console.ReadLine());
        }

        public void AtualizarTarefa() {
            Console.WriteLine("Qual tarefa deseja atualizar? ");
            string taref = Console.ReadLine();
            if (Tarefas.Contains(taref))
            {
                Console.WriteLine("Qual a nova tarefa?");
                int index = Tarefas.IndexOf(taref);
                Tarefas[index] = Console.ReadLine();
            }
        }
        public void ListarTodasAsTarefas() {
            foreach (var item in Tarefas)
                Console.WriteLine(item);
        }
     

        }



    }
    

