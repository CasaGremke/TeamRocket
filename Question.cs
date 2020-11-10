using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRock
{
    public class Question
    {
        public int category;
        public int difficulty;
        public string qText;
        public string correct;
        public List<string> incorrect;

        public int Category { get; set; }

        public int Difficulty { get; set; }

        public string QText { get; set; }

        public string Correct { get; set; }

        public List<string> Incorrect { get; set; }

        public Question() : this(0, 0, "", "")
        {
        }

        public Question(int c, int d, string q, string co)
        {
            Category = c;
            Difficulty = d;
            QText = q;
            Correct = co;
            Incorrect = new List<string>();
        }
        public Question(int c, int d, string q,  string co, List<string> iC)
        {
            Category = c;
            Difficulty = d;
            QText = q;
            Correct = co;
            Incorrect = iC;
        }
        public override string ToString()
        {
            string inCorrectList = "";
            foreach (string l in Incorrect)
            {
                inCorrectList += (l + " ");
            }
            return Category.ToString() + " " + Difficulty.ToString() + " " + QText + " " + Correct + " " + inCorrectList;
        }
    }
}
