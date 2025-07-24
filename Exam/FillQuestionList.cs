using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class FillQuestionList
    {
        public List<Question>Questions=new List<Question>();
        
        public FillQuestionList()
        {

            Questions.Add(new Question
            {
                Header = "Choice The correct Answer",
                Body = "Which keyword is used to define a class in C#?",
                Mark = 1,
                AnswerList = new Answer[]
                {
                    new Answer(1,"Class"),
                    new Answer(2,"Struct"),
                    new Answer(3,"Enum"),
                    new Answer(4,"define")

                },


                CorrectAnswer = new Answer(1, "Class")

            }
            );
            Questions.Add(new Question
            {
                Header = "Choice The correct Answer",
                Body = "What is the default access modifier in class?",
                Mark = 1,
                AnswerList = new Answer[]
                {
                    
                    new Answer(1,"private"),
                    new Answer(2,"internal"),
                    new Answer(3,"public"),
                    new Answer(4,"protected")

                },


                CorrectAnswer = new Answer(1, "private")

            }
            );
            Questions.Add(new Question
            {
                Header = "Choice The correct Answer",
                Body = "What is the OOP?",
                Mark = 1,
                AnswerList = new Answer[]
                {
                    new Answer(1,"Programming language"),
                    new Answer(2,"paradiam (way to write code)"),
                    new Answer(3,"blueprint of class"),
                    new Answer(4,"none of these")

                },


                CorrectAnswer = new Answer(2, "paradiam (way to write code)")

            }
            );
            Questions.Add(new Question
            {
                Header = "Choice The correct Answer",
                Body = "Which of the following is NOT a principle of Object - Oriented Programming ?",
                Mark = 1,
                AnswerList = new Answer[]
                {
                    new Answer(1,"Inhertance"),
                    new Answer(2,"Polymorphism"),
                    new Answer(3,"Compilation"),
                    new Answer(4,"Encapsulation")

                },


                CorrectAnswer = new Answer(3, "Compilation")

            }
            );
            Questions.Add(new Question
            {
                Header = "Choice The correct Answer",
                Body = "Which of the following allows method overriding in C#?",
                Mark = 1,
                AnswerList = new Answer[]
                {
                    new Answer(1,"Const"),
                    new Answer(2,"ref"),
                    new Answer(3,"sealed"),
                    new Answer(4,"virtual")

                },


                CorrectAnswer = new Answer(4, "virtual")

            }
            );
            Questions.Add(new Question
            {
                Header = "Choose True or False",
                Body = "C# is an interpreted language .",
                Mark = 1,
                AnswerList = new Answer[]
            {
             new Answer(1, "True"),
             new Answer(2, "False")
             },
                CorrectAnswer = new Answer(2, "False")
            });

            Questions.Add(new Question
            {
                Header = "Choose True or False",
                Body = "A static method can be called without creating an object.",
                Mark = 1,
                AnswerList = new Answer[]
                {
        new Answer(1, "True"),
        new Answer(2, "False")
                },
                CorrectAnswer = new Answer(1, "True")
            });

            Questions.Add(new Question
            {
                Header = "Choose True or False",
                Body = "An interface in C# can contain implementation of methods.",
                Mark = 1,
                AnswerList = new Answer[]
                {
        new Answer(1, "True"),
        new Answer(2, "False")
                },
                CorrectAnswer = new Answer(2, "False")
            });

            Questions.Add(new Question
            {
                Header = "Choose True or False",
                Body = "The 'const' keyword prevents user from change the value of variable.",
                Mark = 1,
                AnswerList = new Answer[]
                {
        new Answer(1, "True"),
        new Answer(2, "False")
                },
                CorrectAnswer = new Answer(1, "True")
            });

            Questions.Add(new Question
            {
                Header = "Choose True or False",
                Body = "In C#, constructors can be overloaded.",
                Mark = 1,
                AnswerList = new Answer[]
                {
        new Answer(1, "True"),
        new Answer(2, "False")
                },
                CorrectAnswer = new Answer(1, "True")
            });

        }

    }
}
