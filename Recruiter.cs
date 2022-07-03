using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{

    public class Recruiter
    {
        public bool RecruitForElectrotechnicsOpened { get; set; } = false;
        public bool RecruitForAutomationAndRoboticsOpened { get; set; } = false;
        public bool RecruitForInformaticsOpened { get; set; } = false;
        public string YearOfElectrotechnicsRecruitment { get;  set; }
        public string YearOfAutomationAndRoboticsRecruitment { get; set; }
        public string YearOfInformaticsRecruitment { get; set; }
        public uint NumberOfElectrotechnicsStudents { get; set; }
        public uint NumberOfAutomationAndRoboticsStudents { get; set; }
        public uint NumberOfInformaticsStudents { get; set; }

        public void OpenRecruiting()
        {
            Console.WriteLine("\n1.Electrotechnics \n2.Automation and Robotics \n3.Informatics");
            var key = Console.ReadKey();
            uint value;

            switch (key.KeyChar)
            {
                case '1':
                    if (RecruitForElectrotechnicsOpened == false)
                    {
                        RecruitForElectrotechnicsOpened = true;
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting is opened for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("\nYear of recruitment: ");
                    YearOfElectrotechnicsRecruitment = Console.ReadLine();

                    Console.Write("Maximum number of students for this field of study: ");
                    UInt32.TryParse(Console.ReadLine(), out value);
                    NumberOfElectrotechnicsStudents = value;
                    break;

                case '2':
                    if (RecruitForAutomationAndRoboticsOpened == false)
                    {
                        RecruitForAutomationAndRoboticsOpened = true;
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting is opened for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    RecruitForAutomationAndRoboticsOpened = true;
                    Console.Write("\nYear of recruitment: ");
                    YearOfAutomationAndRoboticsRecruitment = Console.ReadLine();

                    Console.Write("Maximum number of students for this field of study: ");
                    UInt32.TryParse(Console.ReadLine(), out value);
                    NumberOfAutomationAndRoboticsStudents = value;
                    break;

                case '3':
                    if (RecruitForInformaticsOpened == false)
                    {
                        RecruitForInformaticsOpened = true;
                    }
                    else
                    {
                        Console.WriteLine("Recruiting is opened for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    RecruitForInformaticsOpened = true;
                    Console.Write("\nYear of recruitment: ");
                    YearOfInformaticsRecruitment = Console.ReadLine();

                    Console.Write("Maximum number of students for this field of study: ");
                    UInt32.TryParse(Console.ReadLine(), out value);
                    NumberOfInformaticsStudents = value;
                    break;
                default:
                    break;
            }
        }

        public void CloseRecruiting(ListOfApplicants eleApplicants, ListOfApplicants arApplicants, ListOfApplicants infApplicants, ListOfStudents listOfStudents)
        {
            Console.WriteLine("\n1.Electrotechnics \n2.Automation and Robotics \n3.Informatics");
            var key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    if (RecruitForElectrotechnicsOpened == true)
                    {
                        RecruitForElectrotechnicsOpened = false;
                        eleApplicants.RemoveApplicant(NumberOfElectrotechnicsStudents);
                        listOfStudents.AddNewStudents(eleApplicants.applicants);
                        eleApplicants.ClearList();
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting is closed for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    break;

                case '2':
                    if (RecruitForAutomationAndRoboticsOpened == true)
                    {
                        RecruitForAutomationAndRoboticsOpened = false;
                        arApplicants.RemoveApplicant(NumberOfAutomationAndRoboticsStudents);
                        listOfStudents.AddNewStudents(arApplicants.applicants);
                        arApplicants.ClearList();
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting is closed for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    break;

                case '3':
                    if (RecruitForInformaticsOpened == true)
                    {
                        RecruitForInformaticsOpened = false;
                        infApplicants.RemoveApplicant(NumberOfInformaticsStudents);
                        listOfStudents.AddNewStudents(infApplicants.applicants);
                        infApplicants.ClearList();
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting is closed for this field of study. \nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("\nIncorrect number.\nPress any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

       
    }
}
