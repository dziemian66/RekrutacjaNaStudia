using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public string FieldOfStudy { get; set; }
        public string YearOfRecruitment { get; set; }
        public uint BasicMathExam { get; set; }
        public uint ExtendedMathExam { get; set; }
        public uint BasicForeignLanguageExam { get; set; }
        public uint ExtendedForeignLanguageExam { get; set; }
        public uint ExtendedPhysicsExam { get; set; }
        public uint ApplicationNumber { get; set; }
        public uint StudentId { get; set; }
        public float PointsSum { get; set; }

        public void ChooseFieldOfStudy(ListOfApplicants eleApplicants, ListOfApplicants arApplicants, ListOfApplicants infApplicants, Recruiter recruiter)
        {
            Console.WriteLine("\n1.Electrotechnics\n" +
                              "2.Automation and Robotics\n" +
                              "3.Informatics");
            var key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    if (recruiter.RecruitForElectrotechnicsOpened)
                    {
                        eleApplicants.AddApplicant("Electrotechnics", recruiter.YearOfElectrotechnicsRecruitment);
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting for Electrotechnics is closed.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    break;

                case '2':
                    if (recruiter.RecruitForAutomationAndRoboticsOpened)
                    {
                        arApplicants.AddApplicant("Automation and Robotics", recruiter.YearOfAutomationAndRoboticsRecruitment);
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting for Automation and Robotics is closed.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                    break;

                case '3':
                    if (recruiter.RecruitForInformaticsOpened)
                    {
                        infApplicants.AddApplicant("Informatics", recruiter.YearOfInformaticsRecruitment);
                    }
                    else
                    {
                        Console.WriteLine("\nRecruiting for Informatics is closed.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
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
