using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string firstname, lastname, coursedesc, workdesc;
            int age, yearlevel, noOfEperience;

            Console.Write("Enter First Name: ");
            firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            lastname = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            coursedesc = Console.ReadLine();

            Console.Write("Enter Year Level: ");
            yearlevel = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Work Experience: ");
            workdesc = Console.ReadLine();

            Console.Write("Enter No. of Experience: ");
            noOfEperience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Registration registration = new Registration(firstname, lastname, age);
            Course course = new Course(firstname, lastname, age, coursedesc, yearlevel);
            WorkExperience workExperience = new WorkExperience(firstname, lastname, age, coursedesc, yearlevel, workdesc, noOfEperience);
            workExperience.displayinfo();
            */
            int length = 3;
            Registration[] registrations = new Registration[length];
            Course[] courses = new Course[length];
            WorkExperience[] workExperiences = new WorkExperience[length];
            string[] firstnames = new string[length], lastnames = new string[length], coursedescs = new string[length], workdescs = new string[length];
            int[] ages = new int[length], yearlevels = new int[length], noOfEperiences = new int[length];

            for (int i = 0; i < registrations.Length; i++)
            {
                Console.Write("Enter First Name: ");
                firstnames[i] = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                lastnames[i] = Console.ReadLine();

                Console.Write("Enter Age: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                coursedescs[i] = Console.ReadLine();

                Console.Write("Enter Year Level: ");
                yearlevels[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Work Experience: ");
                workdescs[i] = Console.ReadLine();

                Console.Write("Enter No. of Experience: ");
                noOfEperiences[i] = Convert.ToInt32(Console.ReadLine());

                registrations[i] = new Registration(firstnames[i], lastnames[i], ages[i]);
                courses[i] = new Course(firstnames[i], lastnames[i], ages[i], coursedescs[i], yearlevels[i]);
                workExperiences[i] = new WorkExperience(firstnames[i], lastnames[i], ages[i], coursedescs[i], yearlevels[i], workdescs[i], noOfEperiences[i]);
            }

            /*for (int i = 0; i < length; i++)
            {
                workExperiences[i].displayinfo();
                Console.WriteLine();
            }
            */

            string search;
            Console.WriteLine("Search by name: ");
            search = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                if (registrations[i].getFirstname() == search) { }
                {
                    Console.WriteLine($"{search} is found in index {i}");
                }
            }

        }
    }
}
