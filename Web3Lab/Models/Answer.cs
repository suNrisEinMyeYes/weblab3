using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web3Lab.Models
{
    public class Answer
    {
        public List<Quiz> answers = new List<Quiz>();
        public int correctAnswer = 0;

        private static Answer instance = null;

        public static Answer Instance
        {
            get
            {
                if (instance == null)
                    instance = new Answer();

                return instance;
            }
        }


        public void Add(Quiz quiz)
        {
            if (quiz.CheckAnswer())
                correctAnswer++;

            answers.Add(quiz);
        }
    }
}
