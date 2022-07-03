using System;

namespace RekrutacjaNaStudia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfApplicants electrotechnicsApplicants = new ListOfApplicants();
            ListOfApplicants automationAndRoboticsApplicants = new ListOfApplicants();
            ListOfApplicants informaticssApplicants = new ListOfApplicants();
            ListOfStudents listOfStudents = new ListOfStudents();
            Recruiter recruiter = new Recruiter();
            Student student = new Student();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to university of technology recruiting app!");
                Console.WriteLine("Who are you?");
                Console.WriteLine("1.Recruiter \n2.Student");
                var key = Console.ReadKey();
                switch(key.KeyChar)
                {
                    case '1':
                        Console.WriteLine("\nPress number (1 or 2) and choose what you want to do:");
                        Console.WriteLine("1.Open recruiting for:");
                        Console.WriteLine("2.Close recruiting for:");
                        key = Console.ReadKey();
                        switch (key.KeyChar)
                        {
                            case '1':
                               recruiter.OpenRecruiting();
                                break;
                            case '2':                                
                                recruiter.CloseRecruiting(electrotechnicsApplicants, automationAndRoboticsApplicants, informaticssApplicants, listOfStudents);
                                break;
                            default:
                                break;
                        }
                        break;
                    case '2':
                        Console.WriteLine("\nPress number (1 or 2) and choose what you want to do:");
                        Console.WriteLine("1.Apply to:");
                        Console.WriteLine("2.Check your application");
                        key = Console.ReadKey();
                        switch (key.KeyChar)
                        {
                            case '1':
                                student.ChooseFieldOfStudy(electrotechnicsApplicants, automationAndRoboticsApplicants, informaticssApplicants, recruiter);
                                break;
                            case '2':
                                listOfStudents.FindStudent();
                                break;
                            default:
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
}