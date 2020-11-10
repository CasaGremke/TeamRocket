using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamRock
{
    public partial class Game : Form
    {

        char DELIM = ',';
        public static Random rand = new Random();
        public static string highName = "";
        public static int highScore = 0;
        public static List<int> categoryList = new List<int>();
        public static List<Question> cat0List = new List<Question>();
        public static List<Question> cat1List = new List<Question>();
        public static List<Question> cat2List = new List<Question>();
        public static List<Question> cat3List = new List<Question>();
        public static List<Question> cat4List = new List<Question>();
        public static List<Question> cat5List = new List<Question>();
        public static List<Question> cat6List = new List<Question>();
        public static List<Question> cat7List = new List<Question>();
        public static List<Question> cat8List = new List<Question>();
        public static List<Question> cat9List = new List<Question>();
        public static List<Question> cat10List = new List<Question>();
        public static List<Question> cat11List = new List<Question>();
        public static List<Question> cat12List = new List<Question>();
        public static List<Question> cat13List = new List<Question>();
        public static List<Question> cat14List = new List<Question>();

        public Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start ad = new Start();
            ad.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                categoryList.Add(i);
            }
            FileStream inFile = new FileStream("QUESTIONS.DAT", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string[] fields;
            string inRecord = reader.ReadLine();
            while (inRecord != null)
            {
                fields = inRecord.Split(DELIM);
                Question q = new Question();
                q.Category = Convert.ToInt32(fields[0]);
                q.Difficulty = Convert.ToInt32(fields[1]);
                q.QText = fields[2];
                q.Correct = fields[3];
                for (int i = 4; i <= 6; i++)
                {
                    q.Incorrect.Add(fields[i]);
                }
                if (q.Category == 0)
                {
                    cat0List.Add(q);
                }
                if (q.Category == 1)
                {
                    cat1List.Add(q);
                }
                if (q.Category == 2)
                {
                    cat2List.Add(q);
                }
                if (q.Category == 3)
                {
                    cat3List.Add(q);
                }
                if (q.Category == 4)
                {
                    cat4List.Add(q);
                }
                if (q.Category == 5)
                {
                    cat5List.Add(q);
                }
                if (q.Category == 6)
                {
                    cat6List.Add(q);
                }
                if (q.Category == 7)
                {
                    cat7List.Add(q);
                }
                if (q.Category == 8)
                {
                    cat8List.Add(q);
                }
                if (q.Category == 9)
                {
                    cat9List.Add(q);
                }
                if (q.Category == 10)
                {
                    cat10List.Add(q);
                }
                if (q.Category == 11)
                {
                    cat11List.Add(q);
                }
                if (q.Category == 12)
                {
                    cat12List.Add(q);
                }
                if (q.Category == 13)
                {
                    cat13List.Add(q);
                }
                if (q.Category == 14)
                {
                    cat14List.Add(q);
                }
                inRecord = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            FileStream hSFile = new FileStream("HSCORE.DAT", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader hSreader = new StreamReader(hSFile);
            string hScore = hSreader.ReadLine();
            string[] scoreFields;
            while (hScore != null)
            {
                scoreFields = hScore.Split(DELIM);
                highName = scoreFields[0];
                highScore = Convert.ToInt32(scoreFields[1]);
                hScore = hSreader.ReadLine();
            }
            hSreader.Close();
            hSFile.Close();

        }
    }
}
