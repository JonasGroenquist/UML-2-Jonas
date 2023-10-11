using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UML_2_Jonas
{
    public class Pizza
    {
        private string _name;
        private string _topping;
        private double _cost;
        private string _number;

        public Pizza(string name, string topping, double cost, string number)
        {
            _name = name;
            _topping = topping;
            _cost = cost;
            _number = number;
        }
        public string Name
        {
            get { return _name; }
        }
        public string Topping
        {
            get { return _topping; }
        }
        public double Cost
        {
            get { return _cost; }
        }
        public string Number
        {
            get { return _number; }
        }

        public override string ToString()
        {
            return $"Pizza {Name} \n Topping: {Topping} \n {Cost} kr,-";
        }
    }
}
