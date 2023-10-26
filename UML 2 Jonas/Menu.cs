using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Jonas
{
    public class Menu
    {
        private PizzaRepositoryList _pizzaRepositoryList;
        private CustomerRepositoryDictionary _customerRepositoryDictionary;
        public Menu(PizzaRepositoryList pizzaRepositoryList, CustomerRepositoryDictionary customerRepositoryDictionary)
        {
            _pizzaRepositoryList = pizzaRepositoryList;
            _customerRepositoryDictionary = customerRepositoryDictionary;
        }
        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------CRUD Listoperationer--------------------");
            Console.WriteLine("\t1.\tTilføj pizza til Pizza RepositoryList");
            Console.WriteLine("\t2.\tUdskriv alle pizzaer fra PizzaRepositoryList");
            Console.WriteLine("\t3.\tSøg efter en pizza i PizzaRepositoryList udfra nummer");
            Console.WriteLine("\t4.\tFjern pizza  fra PizzaRepositoryList");
            Console.WriteLine("\t5.\tOpdater pizza i PizzaRepositoryList");
            Console.WriteLine("\t---------------CRUD Dictionaryoperationer--------------------");
            Console.WriteLine("\t6.\tTilføj kunde til CustomerRepositoryDictionary");
            Console.WriteLine("\t7.\tUdskriv alle kunder fra CustomerRepositoryDictionary");
            Console.WriteLine("\t8.\tSøg efter en kunde i CustomerRepositoryDictionary udfra telefon nummer");
            Console.WriteLine("\t9.\tFjern kunde i CustomerRepositoryDictionary");
            Console.WriteLine("\t10.\tOpdater kunde fra CustomerRepositoryDictionary");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }
        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        //Metode der indlæser og håndterer add Pizza
                        AddPizzaToList();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Print pizzas");
                        _pizzaRepositoryList.PrintPizza();
                        break;
                    case 3:
                        Console.Clear();
                        SearchPizzaList();
                        break;
                    case 4:
                        Console.Clear();
                        //Console.WriteLine("To be implemented!");
                        DeletePizzaFromList();
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePizzaList();
                        break;
                    case 6:
                        Console.Clear();
                        AddCustomerToDictionary();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Print customers");
                        _customerRepositoryDictionary.PrintCustomer();
                        break;
                    case 8:
                        Console.Clear();
                        SearchCustomerDictionary();
                        break;
                    case 9:
                        Console.Clear();
                        DeleteCustomerFromDictionary();
                        break;
                    case 10:
                        Console.Clear();
                        UpdateCustomerDictionary();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();
            }
        }
        private void AddPizzaToList()
        {
            Console.WriteLine("Add pizza");
            Console.WriteLine("Angiv nummer");
            string number = Console.ReadLine();
            Console.WriteLine("Angiv navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv topping");
            string topping = Console.ReadLine();
            Console.WriteLine("Angiv pris");
            double cost = double.Parse(Console.ReadLine());
            Pizza p = new Pizza(name, topping, cost, number);
            _pizzaRepositoryList.AddPizza(p);
        }
        private void SearchPizzaList()
        {
            Console.WriteLine("Search pizza");
            Console.WriteLine("Angiv nummer");
            string number = Console.ReadLine();
            Pizza pizza = _pizzaRepositoryList.LookupPizza(number);
            if (pizza == null)
            {
                Console.WriteLine("Pizza eksisterer ikke");
            }
            else
            {
                Console.WriteLine(pizza);
            }
            Console.ReadLine();
        }
        private void DeletePizzaFromList()
        {
            Console.WriteLine("Delete pizza");
            Console.WriteLine("Angiv nummer");
            string number = Console.ReadLine();
            _pizzaRepositoryList.DeletePizza(number);
        }
        private void UpdatePizzaList()
        {
            Console.WriteLine("Update pizza");
            Console.WriteLine("Angiv nummer på pizza der skal opdateres");
            string numberOld = Console.ReadLine();
            Pizza pizza = _pizzaRepositoryList.LookupPizza(numberOld);
            if (pizza == null)
            {
                Console.WriteLine("Pizza eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Update Pizza");
                Console.WriteLine("Angiv nummber");
                string number = Console.ReadLine();
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv topping");
                string topping = Console.ReadLine();
                Console.WriteLine("Angiv pris");
                double cost = int.Parse(Console.ReadLine());

                Pizza updatedPizza = new Pizza(name, topping, cost, number);

                _pizzaRepositoryList.UpdatePizza(numberOld, updatedPizza);
                Console.WriteLine("Pizza er opdateret");
                Console.ReadLine();
            }
        }
        private void AddCustomerToDictionary()
        {
            Console.WriteLine("Add customer");
            Console.WriteLine("Angiv navn");
            string name = Console.ReadLine();
            Console.WriteLine("Angiv email");
            string email = Console.ReadLine();
            Console.WriteLine("Angiv tlf nummer");
            string phone = Console.ReadLine();
            Console.WriteLine("Angiv adresse");
            string adress = Console.ReadLine();
            Customer b = new Customer(name, email, phone, adress);
            _customerRepositoryDictionary.AddCustomer(b);
        }
        private void SearchCustomerDictionary()
        {
            Console.WriteLine("Search customer");
            Console.WriteLine("Angiv tlf nummer");
            string phone = Console.ReadLine();
            Customer customer = _customerRepositoryDictionary.LookupCustomer(phone);
            if (customer == null)
            {
                Console.WriteLine("kunde eksisterer ikke");
            }
            else
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }
        private void DeleteCustomerFromDictionary()
        {
            Console.WriteLine("Delete customer");
            Console.WriteLine("Angiv tlf nummer");
            string phone = Console.ReadLine();
            _customerRepositoryDictionary.DeleteCustomer(phone);
        }
        private void UpdateCustomerDictionary()
        {
            Console.WriteLine("Update customer");
            Console.WriteLine("Angiv tlf nummer på kunden der skal opdateres");
            string phoneOld = Console.ReadLine();
            Customer customer = _customerRepositoryDictionary.LookupCustomer(phoneOld);
            if (customer == null)
            {
                Console.WriteLine("Kunde eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Update customer");
                Console.WriteLine("Angiv navn");
                string name = Console.ReadLine();
                Console.WriteLine("Angiv email");
                string email = Console.ReadLine();
                Console.WriteLine("Angiv tlf nummer");
                string phone = Console.ReadLine();
                Console.WriteLine("Angiv adresse");
                string adress = Console.ReadLine();

                Customer updatedCustomer = new Customer(name, email, phone, adress);

                _customerRepositoryDictionary.UpdateCustomer(phoneOld, updatedCustomer);
                Console.WriteLine("kunde er opdateret");
                Console.ReadLine();
            }
        }
    }
}
