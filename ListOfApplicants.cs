using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class ListOfApplicants
    {
        private uint applicantNumber = 0;
        public List<Student> applicants;
        public ListOfApplicants()
        {
            applicants = new List<Student>();
        }

        public uint AddApplicant(string fieldOfStudy, string yearOfRecruitment)
        {
            uint value;
            Student student = new Student(); 
            Console.WriteLine("\nComplete the application:");
            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Surname: ");
            student.Surname = Console.ReadLine();

            Console.Write("PESEL: ");
            student.Pesel = Console.ReadLine();

            Console.Write("Basic Math exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            student.BasicMathExam = value;

            Console.Write("Extended Math exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            student.ExtendedMathExam = value;

            Console.Write("Basic Foreign Language exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            student.BasicForeignLanguageExam = value;

            Console.Write("Extended Foreign Language exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            student.ExtendedForeignLanguageExam = value;

            Console.Write("Extended Physics exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            student.ExtendedPhysicsExam = value;

            student.FieldOfStudy = fieldOfStudy;
            student.YearOfRecruitment = yearOfRecruitment;
            student.ApplicationNumber = applicantNumber;

            applicants.Add(student);
            switch(fieldOfStudy)
            {
                case "Electrotechnics":
                    student.PointsSum = Qualified.SumPointsForElectrotechnics(student);
                    break;
                case "Automation and Robotics":
                    student.PointsSum = Qualified.SumPointsForAutomationAndRobotics(student);
                    break;
                case "Informatics":
                    student.PointsSum = Qualified.SumPointsForInformatics(student);
                    break;
                default:
                    break;
            }
            
            return applicantNumber;
        }

        public void RemoveApplicant(uint numberOfRecruitStudents)
        {
            uint deleteStudent;

            if (numberOfRecruitStudents < (uint)applicants.Count)
            {
                deleteStudent = (uint)applicants.Count - numberOfRecruitStudents; //Number of students to delete        
            }
            else
            {
                deleteStudent = 0;
            }
            for (int i = 0; i < deleteStudent; i++)
            {                            
                applicants.RemoveAt(Qualified.CheckQualified(applicants));
            }
        }
        public void ClearList()
        {
            applicants.Clear();
        }
    }
}
