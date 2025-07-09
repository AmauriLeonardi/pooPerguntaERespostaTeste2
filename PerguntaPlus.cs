using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    public class PerguntaPlus: Pergunta
    {
        // Construtores
        public PerguntaPlus(): base()
        {
            this.Dica = "";
        }

        public PerguntaPlus(string texto, string resposta, string dica) : base(texto, resposta)
        {
            this.Dica = "";
        }

        public string Dica { get; set; }
    }
}
