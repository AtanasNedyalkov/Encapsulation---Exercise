using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Shopping_Spree
{
    public class Product
    {
        private const int IsNegativeOrZero = 0;
        private string name;
        private int cost;
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (cost<IsNegativeOrZero)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
