using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    class Carro
    {
        private string name;
        private string label;
        private int year;

        public Carro() { }
        public Carro(string name_car, string label_car, int year_car)
        {
            name = name_car;
            label = label_car;
            year = year_car;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Label
        {
            get => label;
            set => label = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }
    }
}
