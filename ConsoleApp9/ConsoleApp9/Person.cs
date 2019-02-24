using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Height { get;  set; }
        protected string Adress { get; set; }
        private int Code { get; set; }
        internal int Cars { get; set; }


        public Person()
        {

        }

        public Person(string firstname, string lastname, double height, string adress, int code, int cars)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Height = height;
            this.Adress = adress;
            this.Code = code;
            this.Cars = cars;
        }

        public override string ToString()
        {
            return $"name: {Firstname + " " + Lastname}, height: {Height}, adress: {Adress}, code: {Code}, cars: {Cars}";
        }

    }
}
