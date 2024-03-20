using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WorkExperience : Course
    {
        private string workDesc;
        private int noOfExperience;
        
        public WorkExperience(string firstname, string lastname, int age, string coursedesc, int yearlevel, string workDesc, int noOfExperience) : base(firstname, lastname, age, coursedesc
            , yearlevel)
        {
            this.workDesc = workDesc;
            this.noOfExperience = noOfExperience;
        }

        public string getWorkDesc() { return workDesc; }
        public int getNoOfExperience() {  return noOfExperience; }

        public override void displayinfo()
        {
            base.displayinfo();
            Console.WriteLine($"Work Experience: {getWorkDesc()}");
            Console.WriteLine($"No. of Experience: {getNoOfExperience()}");
        }
    }
}
