using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp
{
    internal class product
    {
        private string name;
        private float price;

        public product() { }
        public product(string name_prod, float price_prod)
        {
            name = name_prod;
            price = price_prod;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }
    }
}
