﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText {  get; set; }

        public Answer(int ansId,string ansText)
        {
            AnswerId = ansId;
            AnswerText = ansText;
            
        }
    }
}
