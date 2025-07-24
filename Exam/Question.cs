using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question
    {
       
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
      
        public  Answer[]? AnswerList { get; set; } 

        public Answer? CorrectAnswer { get; set; }
       
    }
}
