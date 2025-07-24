using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam:BaseExam
    {
        int totalGarde = 0;

        public override void ShowExam()
        {
            Console.WriteLine("\t\t\t--------------------[Final Exam]-------------------------");
            FillQuestionList fillQuestionList = new FillQuestionList();
             QuestionList= fillQuestionList.Questions ;
            int Choice;
            List<int>UsersAnswer = new List<int>();
            List<Answer> CorrectAnswers = new List<Answer>();
            bool valid = false;
            foreach (var question in QuestionList)
            {
                valid = false; //reset to anther question
                Console.WriteLine($"\t\t\tQuestion :---- \n\t\t\t{question.Header}\n\t\t\t{question.Body}\n");
                foreach(var ans in question.AnswerList)
                {
                    Console.WriteLine("\t\t\t"+ans.AnswerId+"-"+ans.AnswerText);
                }
                while (!valid)
                {
                    try
                    {
                        Console.Write("\n\t\t\tWhat is your Answer(write the num of choice) : ");
                        Choice = int.Parse(Console.ReadLine());
                        if (Choice >= 1 && Choice <= 4)
                        {
                            UsersAnswer.Add((Choice));
                            valid = true;
                            if (Choice == question?.CorrectAnswer?.AnswerId)
                            {
                                totalGarde += question.Mark;
                            }
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
                CorrectAnswers.Add(question.CorrectAnswer);
                Console.WriteLine("\t\t\t---------------------------------------");
                Console.WriteLine();
            }
            
            Console.WriteLine("\n\t\t\t---------------------------------------");
            Console.WriteLine("\t\t\t------------The end of exam------------");
            Console.WriteLine("\t\t\t---------------------------------------\n");
            Console.WriteLine($"\t\t\tYour grade is {totalGarde} from 10 ");
            Console.WriteLine("\n\t\t\t---------------------------------------\n");
            Console.WriteLine("\t\t\tthese are correct answers : \n");
            Console.WriteLine("\n\t\t\t---------------------------------------\n");
            foreach (var ans in CorrectAnswers)
            {
                Console.WriteLine($"\t\t\t{ans.AnswerId}-{ans.AnswerText} ");
               

            }
            Console.WriteLine("\n\t\t\t---------------------------------------\n");
            Console.WriteLine("\t\t\tand these are your answers : \n");
            Console.WriteLine("\n\t\t\t---------------------------------------\n");
            foreach (int ans in UsersAnswer)
            {
                Console.WriteLine("\t\t\t\t\t" + ans);

            }
        }
    }
}
