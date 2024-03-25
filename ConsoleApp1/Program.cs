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

                Console.WriteLine();
                workExperiences[i] = new WorkExperience(firstnames[i], lastnames[i], ages[i], coursedescs[i], yearlevels[i], workdescs[i], noOfEperiences[i]);
            }
            Console.WriteLine("Sort Ascending");
            sortAsc(workExperiences);
            for (int i = 0; i < length; i++)
            {
                string fullName = workExperiences[i].getFirstname() + " " + workExperiences[i].getLastname();
                Console.WriteLine(fullName);
            }

            Console.WriteLine("Sort Descending");
            sortDesc(workExperiences);
            for (int i = 0; i < length; i++)
            {
                string fullName = workExperiences[i].getFirstname() + " " + workExperiences[i].getLastname();
                Console.WriteLine(fullName);
            }

            /*string search;
            Console.WriteLine("Search by name: ");
            search = Console.ReadLine();
            searchByName(search, workExperiences);*/

        }

        static public void searchByName(string name, WorkExperience[] workExperience)
        {
            for (int i = 0; i < workExperience.Length; i++)
            {
                string fullName = workExperience[i].getFirstname() + " " + workExperience[i].getLastname();
                if (fullName.Equals(name))
                {
                    Console.WriteLine($"{name} is found in index {i+1}");
                }
            }
        }

        static public void sortAsc(WorkExperience[] workExperience)
        {

            for (int i = 0; i < workExperience.Length - 1; i++)
            {
                for (int j = 0; j < workExperience.Length - i - 1; j++)
                {
                    if (string.Compare(workExperience[j].getFirstname(), workExperience[j + 1].getFirstname()) > 0)
                    {
                        WorkExperience temp = workExperience[j];
                        workExperience[j] = workExperience[j + 1];
                        workExperience[j + 1] = temp;
                    }
                }
            }
        }
        static public void sortDesc(WorkExperience[] workExperience)
        {

            for (int i = 0; i < workExperience.Length - 1; i++)
            {
                for (int j = 0; j < workExperience.Length - i - 1; j++)
                {
                    if (string.Compare(workExperience[j].getFirstname(), workExperience[j + 1].getFirstname()) < 0)
                    {
                        WorkExperience temp = workExperience[j];
                        workExperience[j] = workExperience[j + 1];
                        workExperience[j + 1] = temp;
                    }
                }
            }
        }
    }
}
