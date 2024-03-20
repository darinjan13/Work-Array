using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Registration
    {
        private string firstname;
        private string lastname;
        private int age;

        public Registration(string firstname, string lastname, int age) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public string getFirstname() { return firstname; }
        public string getLastname() { return lastname;}
        public int getAge() { return age;}
        public virtual void displayinfo()
        {
            Console.WriteLine($"Name\t: {getFirstname()} {getLastname()}");
            Console.WriteLine($"Age\t: {getAge()}");
        }
    }
}
