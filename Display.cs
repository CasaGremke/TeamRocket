using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamRock
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start ad = new Start();
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {

            int newCategory = Game.rand.Next(0, 15);
            if (newCategory == 0)
            {
                int newQuestion = Game.rand.Next(0, Game.cat0List.Count());
                Question newQ = Game.cat0List[newQuestion];
                chooseLayout(newQ);

            }
            if (newCategory == 1)
            {

                int newQuestion = Game.rand.Next(0, Game.cat1List.Count());
                Question newQ = Game.cat1List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 2)
            {

                int newQuestion = Game.rand.Next(0, Game.cat2List.Count());
                Question newQ = Game.cat2List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 3)
            {

                int newQuestion = Game.rand.Next(0, Game.cat3List.Count());
                Question newQ = Game.cat3List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 4)
            {

                int newQuestion = Game.rand.Next(0, Game.cat4List.Count());
                Question newQ = Game.cat4List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 5)
            {

                int newQuestion = Game.rand.Next(0, Game.cat5List.Count());
                Question newQ = Game.cat5List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 6)
            {

                int newQuestion = Game.rand.Next(0, Game.cat6List.Count());
                Question newQ = Game.cat6List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 7)
            {

                int newQuestion = Game.rand.Next(0, Game.cat7List.Count());
                Question newQ = Game.cat7List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 8)
            {

                int newQuestion = Game.rand.Next(0, Game.cat8List.Count());
                Question newQ = Game.cat8List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 9)
            {

                int newQuestion = Game.rand.Next(0, Game.cat9List.Count());
                Question newQ = Game.cat9List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 10)
            {

                int newQuestion = Game.rand.Next(0, Game.cat10List.Count());
                Question newQ = Game.cat10List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 11)
            {

                int newQuestion = Game.rand.Next(0, Game.cat11List.Count());
                Question newQ = Game.cat11List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 12)
            {

                int newQuestion = Game.rand.Next(0, Game.cat12List.Count());
                Question newQ = Game.cat12List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 13)
            {

                int newQuestion = Game.rand.Next(0, Game.cat13List.Count());
                Question newQ = Game.cat13List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 14)
            {

                int newQuestion = Game.rand.Next(0, Game.cat14List.Count());
                Question newQ = Game.cat14List[newQuestion];
                chooseLayout(newQ);
            }
        }
        private void chooseLayout(Question newQ)
        {
            lblQuestions.Text = newQ.QText;
            int chooseRight = Game.rand.Next(1, 5);
            if (chooseRight == 1)
            {
                lblDisplay.Text = newQ.Correct;
                label1.Text = newQ.Incorrect[0];
                label2.Text = newQ.Incorrect[1];
                label3.Text = newQ.Incorrect[2];
            }
            else if (chooseRight == 2)
            {

                label1.Text = newQ.Correct;
                lblDisplay.Text = newQ.Incorrect[0];
                label2.Text = newQ.Incorrect[1];
                label3.Text = newQ.Incorrect[2];
            }
            else if (chooseRight == 3)
            {

                label2.Text = newQ.Correct;
                label1.Text = newQ.Incorrect[0];
                lblDisplay.Text = newQ.Incorrect[1];
                label3.Text = newQ.Incorrect[2];
            }
            else
            {

                label3.Text = newQ.Correct;
                label2.Text = newQ.Incorrect[0];
                label1.Text = newQ.Incorrect[1];
                lblDisplay.Text = newQ.Incorrect[2];
            }
        }

    }
}
