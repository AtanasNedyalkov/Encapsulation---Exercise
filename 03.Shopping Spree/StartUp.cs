using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            var inputPeople = Console.ReadLine().Split(';' , StringSplitOptions.RemoveEmptyEntries);
            var inputProduct = Console.ReadLine().Split(';' , StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var token in inputPeople)
                {
                    var tokens = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var name = tokens[0];
                    var money = int.Parse(tokens[1]);
                    var person = new Person(name, money);
                    people.Add(person);
                }
                foreach (var token in inputProduct)
                {
                    var tokens = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    var name = tokens[0];
                    var cost = int.Parse(tokens[1]);
                    var product = new Product(name, cost);
                    products.Add(product);

                }
                string command;

                while ((command=Console.ReadLine())!="END")
                {
                    var info = command.Split();
                    var personName = info[0];
                    var productName = info[1];
                    var product = products.FirstOrDefault(p => p.Name == productName);

                    try
                    {
                        people.FirstOrDefault(p => p.Name == personName)
                              .BuyProduct(product);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch(Exception ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            foreach (var per in people)
            {
                Console.WriteLine(per.ToString());
            }
        }
    }
}
