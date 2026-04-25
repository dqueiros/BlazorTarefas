using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTarefas.Shared.Data
{
    public class Tarefa
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
