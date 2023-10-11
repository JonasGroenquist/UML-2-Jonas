using UML_2_Jonas;

namespace Test_uml2
{
    [TestClass]
    public class TestPizzaRepository
    {
        private PizzaRepositoryList pizzaRepositoryList = new PizzaRepositoryList();

        public void TestSetUp()
        {
            Pizza p1 = new Pizza("Margarita", "Cheese", 70, "1");
            Pizza p2 = new Pizza("Vesuvio", "Ham & Cheese", 75, "2");
            pizzaRepositoryList.AddPizza(p1);
            pizzaRepositoryList.AddPizza(p2);
        }

        [TestMethod]
        public void TestAddPizza()
        {
            //arrange
            TestSetUp();
            

            //act
            int numbersBefore = pizzaRepositoryList.Count;
            Pizza p3 = new Pizza("Peperoni", "Peperoni & Cheese", 80, "3");
            pizzaRepositoryList.AddPizza(p3);
            int numbersAfter = pizzaRepositoryList.Count;

            //assert
            Assert.AreEqual(numbersBefore+1, numbersAfter);
        }

        [TestMethod]
        public void TestRemovePizza()
        {
            //arrange
            TestSetUp();

            //act


            //assert
        }
    }
}