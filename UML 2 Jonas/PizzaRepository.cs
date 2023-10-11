using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Jonas
{
    public class PizzaRepositoryList
    {
        private List<Pizza> _pizzas;

        public PizzaRepositoryList()
        {
            _pizzas = new List<Pizza>();
        }
        public int Count
        {
            get { return _pizzas.Count; }
        }
        public void AddPizza(Pizza aPizza)
        {
            if (LookupPizza(aPizza.Number) == null)
            {
                _pizzas.Add(aPizza);
            }
        }
        public Pizza? LookupPizza(string number)
        {
            foreach (var pizza in _pizzas)
            {
                if (pizza.Number == number)
                    return pizza;
            }
            return null;
        }
        public void DeletePizza(string number)
        {
            for (int i = 0; i < _pizzas.Count; i++)
            {
                if (_pizzas[i].Number == number)
                {
                    _pizzas.RemoveAt(i);
                }
            }

        }
        public void PrintPizza()
        {
            foreach (var pizza in _pizzas)
            {
                Console.WriteLine(pizza + " ");
            }
        }
        public void UpdatePizza(string number, Pizza pizzaToUpdate)
        {
            for (int i = 0; i < _pizzas.Count; i++)
            {
                if (_pizzas[i].Number == number)
                {
                    _pizzas[i] = pizzaToUpdate;
                }
            }
        }
    }
}
