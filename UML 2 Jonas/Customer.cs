using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_Jonas
{
    public class Customer
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _adress;


        public Customer(string name, string email, string phone, string adress)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _adress = adress;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public override string ToString()
        {
            return $"Customer Name: {Name} \n Email: {Email} \n Phone: {Phone} \n Adress: {Adress}";

        }
    }
}
