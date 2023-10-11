// See https://aka.ms/new-console-template for more information
using UML_2_Jonas;

PizzaRepositoryList pizzaRepositoryList = new PizzaRepositoryList();
CustomerRepositoryDictionary customerRepositoryDictionary = new CustomerRepositoryDictionary();
Pizza p1 = new Pizza("Margarita", "Cheesse", 70, "1");
Pizza p2 = new Pizza("Vesuvio", "Ham & Cheese", 75, "2");
Pizza p3 = new Pizza("Pepperoni", "Pepperoni & Cheese", 80, "3");
pizzaRepositoryList.AddPizza(p1);
pizzaRepositoryList.AddPizza(p2);
pizzaRepositoryList.AddPizza(p3);
Customer c1 = new Customer("Jonas", "jonas123@hotmail.com", "12345678", "Baunedalen 1");
customerRepositoryDictionary.AddCustomer(c1);

//pizzaRepositoryList.PrintPizza();

Menu menu = new Menu(pizzaRepositoryList, customerRepositoryDictionary);
menu.Run();
Console.ReadLine();
//Console.WriteLine("Test af search:");
//Pizza foundPizza = pizzaRepositoryList.LookupPizza("2");
//if (foundPizza != null)
//{
//    //Udskriv foundPizza
//    Console.WriteLine($"Pizza fundet {foundPizza.ToString()}");
//}
//else
//{
//    //Udskriv pizza ikke fundet
//    Console.WriteLine("Pizza ikke fundet");
//}