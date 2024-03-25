using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            do
            {
                menu();
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < workExperiences.Length; i++)
                        {
                            string fullName = workExperiences[i].getFirstname() + " " + workExperiences[i].getLastname();
                            Console.WriteLine($"Name: {fullName}");
                            Console.WriteLine($"Age: {workExperiences[i].getAge()}");
                            Console.WriteLine($"Course: {workExperiences[i].getCoursedesc()}");
                            Console.WriteLine($"Year Level: {workExperiences[i].getYearlevel()}");
                            Console.WriteLine($"Work: {workExperiences[i].getWorkDesc()}");
                            Console.WriteLine($"Work Experience: {workExperiences[i].getNoOfExperience()}");
                        }
                        break;
                    case 2:
                        sortAsc(workExperiences);
                        break;
                    case 3:
                        sortDesc(workExperiences);
                        break;
                    case 4:
                        Console.WriteLine("Enter name to search: ");
                        string name = Console.ReadLine();
                        searchByName(name, workExperiences);
                        break;
                    case 5:
                        return;
                }
            } while (true);

        }

        static public void menu()
        {
            Console.WriteLine("1 - Dsiplay Contents");
            Console.WriteLine("2 - Sort Ascending");
            Console.WriteLine("3 - Sort Descending");
            Console.WriteLine("4 - Search by Name");
            Console.WriteLine("5 - Quit");
            
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
