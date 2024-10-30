using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    internal class Aluno
    {
        private string name;
        private float grade;

        public Aluno() { }
        public Aluno(string name_aluno, float grade_aluno)
        {
            name = name_aluno;
            grade = grade_aluno;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public float Grade
        {
            get => grade;
            set => grade = value;
        }
    }
}