using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class BaseExam
    {
        public int Time { get; set; }
        public int NumOfQuestion { get; set; }
        public List<Question>QuestionList;

       
        public abstract void ShowExam();
    }
}
