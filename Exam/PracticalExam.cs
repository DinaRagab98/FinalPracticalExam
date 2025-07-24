using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PractialExam : BaseExam
    {
        

        public override void ShowExam()
        {
            Console.WriteLine("\t\t\t--------------------[practical Exam]-------------------------");
            FillQuestionList fillQuestionList = new FillQuestionList();
            QuestionList = fillQuestionList.Questions;
            int Choice;
            List<Answer> CorrectAnswers = new List<Answer>();
            for (var i=0; i< QuestionList.Count()/2;i++)
            {
                bool valid = false;

                Console.WriteLine($"\t\t\t--------Question[{i+1}] :------- \n\n\t\t\t{QuestionList[i].Header}\n\t\t\t{QuestionList[i].Body}\n");
                foreach (var ans in  QuestionList[i].AnswerList)
                {
                    Console.WriteLine("\t\t\t"+ans.AnswerId + "-" + ans.AnswerText);
                }
                while (!valid)
                {
                    try
                    {
                        Console.Write("\n\t\t\tWhat is your Answer(write the num of choice) : ");
                        Choice = int.Parse(Console.ReadLine());
                        if (Choice >= 1 && Choice <= 4)
                        {
                           
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("\t\t\tInvalid choice. Please enter a number between 1 and 4.");

                        }
                    }
                    catch
                    {
                        Console.WriteLine("\t\t\tInvalid choice. Please enter a number between 1 and 4.");

                    }
                }
                CorrectAnswers.Add(QuestionList[i].CorrectAnswer);
                
                Console.WriteLine("\t\t\t---------------------------------------");
                Console.WriteLine();
            }
            Console.WriteLine("\n\t\t\t---------------------------------------");
            Console.WriteLine("\t\t\t------------The end of exam------------");
            Console.WriteLine("\n\t\t\t---------------------------------------");
            Console.WriteLine("\t\t\tthese are the correct answers : \n");
            Console.WriteLine("\n\t\t\t---------------------------------------");
            foreach (var ans in CorrectAnswers  )
            {
                Console.WriteLine($"\t\t\t{ans.AnswerId}-{ans.AnswerText} ");
            }
        }
    }
}
