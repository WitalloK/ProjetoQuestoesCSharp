using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    internal class Pessoa
    {
        string talk;

        public Pessoa() { }

        public Pessoa(string talk_p)
        {
            talk = talk_p;
        }

        public string Talk
        {
            get => talk;
            set => talk = value;
        }
    }
}