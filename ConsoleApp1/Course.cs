using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course : Registration
    {
        private string coursedesc;
        private int yearlevel;

        public Course(string firstname, string lastname, int age, string coursedesc, int yearlevel) : base(firstname, lastname, age)
        {
            this.coursedesc = coursedesc;
            this.yearlevel = yearlevel;
        }

        public string getCoursedesc() {  return coursedesc; }
        public int getYearlevel() {  return yearlevel; }

        public override void displayinfo()
        {
            base.displayinfo();
            Console.WriteLine($"Course: {getCoursedesc()}");
            Console.WriteLine($"Year Level: {getYearlevel()}");
        }
    }
}
