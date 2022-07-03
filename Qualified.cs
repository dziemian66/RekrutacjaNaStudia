using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public static class Qualified
    {
        //Constants
        //Multipliers for Electrotechnics 
        public const float MATH_B_ET = 0.5f; //Multiplier for Basic Mathematic 
        public const float MATH_E_ET = 1.75f; //Multiplier for Extended Mathematic
        public const float FL_B_ET = 0.2f; //Multiplier for Basic Foreign Language
        public const float FL_E_ET = 0.4f; //Multiplier for Extended Foreign Language
        public const float PHY_E_ET = 1.5f; //Multiplier for Extended Physics

        //Multipliers for Automation and Robotics 
        public const float MATH_B_AR = 0.5f; //Multiplier for Basic Mathematic 
        public const float MATH_E_AR = 1.5f; //Multiplier for Extended Mathematic
        public const float FL_B_AR = 0.4f; //Multiplier for Basic Foreign Language
        public const float FL_E_AR = 0.6f; //Multiplier for Extended Foreign Language
        public const float PHY_E_AR = 1.2f; //Multiplier for Extended Physics

        //Multipliers for Informatics
        public const float MATH_B_INF = 0.75f; //Multiplier for Basic Mathematic
        public const float MATH_E_INF = 1.5f; //Multiplier for Extended Mathematic
        public const float FL_B_INF = 0.25f; //Multiplier for Basic Foreign Language
        public const float FL_E_INF = 0.75f; //Multiplier for Extended Foreign Language
        public const float PHY_E_INF = 1.0f; //Multiplier for Extended Physics


        public static float SumPointsForElectrotechnics(Student student)
        {
            float sumPoints = MATH_B_ET * student.BasicMathExam + MATH_E_ET * student.ExtendedMathExam + FL_B_ET * student.BasicForeignLanguageExam +
                             + FL_E_ET * student.ExtendedForeignLanguageExam + PHY_E_ET * student.ExtendedPhysicsExam;
            return sumPoints;
        }

        public static float SumPointsForAutomationAndRobotics(Student student)
        {
            float sumPoints = MATH_B_AR * student.BasicMathExam + MATH_E_AR * student.ExtendedMathExam + FL_B_AR * student.BasicForeignLanguageExam +
                             +FL_E_AR * student.ExtendedForeignLanguageExam + PHY_E_AR * student.ExtendedPhysicsExam;
            return sumPoints;
        }

        public static float SumPointsForInformatics(Student student)
        {
            float sumPoints = MATH_B_INF * student.BasicMathExam + MATH_E_INF * student.ExtendedMathExam + FL_B_INF * student.BasicForeignLanguageExam +
                             +FL_E_INF * student.ExtendedForeignLanguageExam + PHY_E_INF * student.ExtendedPhysicsExam;
            return sumPoints;
        }

        public static int CheckQualified(List<Student> applicants)      
        {         
            if (applicants.Count == 0)
            {
                return -1; // Breaking the loop when number of applicants is 0
            }

            float minPointsSum = applicants[0].PointsSum;
            int applicantToDelete = 0;

            for (int i = 0; i < applicants.Count; i++)
            {

                    if (minPointsSum > applicants[i].PointsSum)
                    {
                        minPointsSum = applicants[i].PointsSum;
                        applicantToDelete = i;
                    }
            }
            return applicantToDelete;
        }         
    }
}
