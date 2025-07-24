using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string  SubjectName { get; set; }
        int ExamType;
        public Subject(int subId,string subName)
        {
            SubjectId = subId;
            SubjectName = subName;
        }
        public void UserInput()
        {
            Console.WriteLine("\t\t\tWhat is the exam Practical[1]/ Final[2]");
            ExamType = int.Parse(Console.ReadLine());
        }
        public void CreateExam()
        {
            Console.WriteLine($"\t\t\t------Hello to {SubjectName} Exam--------- ");
            bool valid = false;
            while (!valid)
            {
                try
                {
                   
                    UserInput();
                    

                    if (ExamType == 1)//practical
                    {
                       Console.Clear();//clear the console 
                        PractialExam practialExam = new PractialExam();
                        practialExam.ShowExam();
                        
                        valid = true; // to exit
                        
                    }
                    else if (ExamType == 2) //final
                    {
                        Console.Clear();
                        FinalExam finalExam = new FinalExam();
                        finalExam.ShowExam();
                       
                        valid = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("\t\t\tInvalid option , please enter 1 or 2 ");
                    }
                   
                }
                catch
                {
                    Console.WriteLine("\t\t\tInvalid option , please enter 1 or 2 ");
                   
                }
                
            }
           
        }
    }
}
