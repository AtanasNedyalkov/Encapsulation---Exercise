using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Shopping_Spree
{
    public class Person
    {
        private const double IsZeroOrNegative = 0; 
        private string name;
        private int money;
        private List<Product> bagOfProducts;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }

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
        public int Money
        {
            get  
            {
                return this.money;
            }
            private set
            {
                if (value < IsZeroOrNegative)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyList<Product> BagOfProducts 
        {
            get 
            {
                return this.bagOfProducts.AsReadOnly();
            }
            set
            {
                
            }
        }
        public void BuyProduct(Product product)
        {
            if (product.Cost>this.Money )
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            this.bagOfProducts.Add(product);
            this.Money -= product.Cost;
        }
        public override string ToString()
        {
            if (this.bagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            var products = this.bagOfProducts.Select(p => p.Name);

            return $"{this.Name} - {string.Join(", ", products)}";
        }
    }
}
