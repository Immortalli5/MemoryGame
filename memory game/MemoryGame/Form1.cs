using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        //variables
        List<Point> points = new List<Point>();
        Random location = new Random();
        PictureBox firstClick;
        PictureBox secondClick;
        int c1; int c2; int c3; int c4; int c5; int c6; int c7; int c8;
        int d1; int d2; int d3; int d4; int d5; int d6; int d7; int d8;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (PictureBox picture in CardPanel.Controls)
            {
                ScoreCounter.Text = "0";
                firstClick = null;
                secondClick = null;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.reverse;
                picture.Enabled = true;
                points.Add(picture.Location);
            }
            foreach(PictureBox picture in CardPanel.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
        }
        #region cards
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.sign1;
            if(firstClick == null && secondClick == null)
            {
                firstClick = Card1;
                checkIfEnable();
                Card1.Enabled = false;
            }
            else if(firstClick != null && secondClick == null)
            {
                secondClick = Card1;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card1.Enabled = false;
                    Duplicate1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate1_Click(object sender, EventArgs e)
        {
            Duplicate1.Image = Properties.Resources.sign1;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate1;
                checkIfEnable();
                Duplicate1.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate1;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card1.Enabled = false;
                    Duplicate1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.sign2;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card2;
                checkIfEnable();
                Card2.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card2;
                Card2.Enabled = false;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card2.Enabled = false;
                    Duplicate2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate2_Click(object sender, EventArgs e)
        {
            Duplicate2.Image = Properties.Resources.sign2;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate2;
                checkIfEnable();
                Duplicate2.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate2;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card2.Enabled = false;
                    Duplicate2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.sign3;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card3;
                checkIfEnable();
                Card3.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card3;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card3.Enabled = false;
                    Duplicate3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate3_Click(object sender, EventArgs e)
        {
            Duplicate3.Image = Properties.Resources.sign3;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate3;
                checkIfEnable();
                Duplicate3.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate3;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card3.Enabled = false;
                    Duplicate3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.sign4;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card4;
                checkIfEnable();
                Card4.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card4;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card4.Enabled = false;
                    Duplicate4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate4_Click(object sender, EventArgs e)
        {
            Duplicate4.Image = Properties.Resources.sign4;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate4;
                checkIfEnable();
                Duplicate4.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate4;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card4.Enabled = false;
                    Duplicate4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.sign5;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card5;
                checkIfEnable();
                Card5.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card5;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card5.Enabled = false;
                    Duplicate5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate5_Click(object sender, EventArgs e)
        {
            Duplicate5.Image = Properties.Resources.sign5;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate5;
                checkIfEnable();
                Duplicate5.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate5;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card5.Enabled = false;
                    Duplicate5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.sign6;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card6;
                checkIfEnable();
                Card6.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card6;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card6.Enabled = false;
                    Duplicate6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate6_Click(object sender, EventArgs e)
        {
            Duplicate6.Image = Properties.Resources.sign6;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate6;
                checkIfEnable();
                Duplicate6.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate6;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card6.Enabled = false;
                    Duplicate6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.sign7;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card7;
                checkIfEnable();
                Card7.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card7;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card7.Enabled = false;
                    Duplicate7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate7_Click(object sender, EventArgs e)
        {
            Duplicate7.Image = Properties.Resources.sign7;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate7;
                checkIfEnable();
                Duplicate7.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate7;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card7.Enabled = false;
                    Duplicate7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.sign8;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Card8;
                checkIfEnable();
                Card8.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Card8;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card8.Enabled = false;
                    Duplicate8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }

        private void Duplicate8_Click(object sender, EventArgs e)
        {
            Duplicate8.Image = Properties.Resources.sign8;
            if (firstClick == null && secondClick == null)
            {
                firstClick = Duplicate8;
                checkIfEnable();
                Duplicate8.Enabled = false;
            }
            else if (firstClick != null && secondClick == null)
            {
                secondClick = Duplicate8;
            }
            if (firstClick != null && secondClick != null)
            {
                if (firstClick.Tag == secondClick.Tag)
                {
                    firstClick = null;
                    secondClick = null;
                    Card8.Enabled = false;
                    Duplicate8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 5);
                    check();
                }
                else
                {
                    recover();
                    checkIfEnable();
                    disable();
                    timer1.Start();
                }
            }
        }
        #endregion

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClick.Image = Properties.Resources.reverse;
            secondClick.Image = Properties.Resources.reverse;
            firstClick = null;
            secondClick = null;
            ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 2);
            recover();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        void check()
        {
            if(Card1.Enabled==false && Duplicate1.Enabled==false && Card2.Enabled == false && Duplicate2.Enabled == false &&
                Card3.Enabled == false && Duplicate3.Enabled == false && Card4.Enabled == false && Duplicate4.Enabled == false &&
                Card5.Enabled == false && Duplicate5.Enabled == false && Card6.Enabled == false && Duplicate6.Enabled == false &&
                Card7.Enabled == false && Duplicate7.Enabled == false && Card8.Enabled == false && Duplicate8.Enabled == false)
            {
                LastScoreCount.Text = ScoreCounter.Text;
                string x;
                x = BestScoreCouter.Text;
                BestScoreCouter.Text = ScoreCounter.Text;
                if (Convert.ToInt32(BestScoreCouter.Text) > Convert.ToInt32(ScoreCounter.Text)) BestScoreCouter.Text = x;
               



            }
        }
            void disable()
        {
            Card1.Enabled = false; Duplicate1.Enabled = false; Card2.Enabled = false; Duplicate2.Enabled = false;
            Card3.Enabled = false; Duplicate3.Enabled = false; Card4.Enabled = false; Duplicate4.Enabled = false;
            Card5.Enabled = false; Duplicate5.Enabled = false; Card6.Enabled = false; Duplicate6.Enabled = false;
            Card7.Enabled = false; Duplicate7.Enabled = false; Card8.Enabled = false; Duplicate8.Enabled = false;
        }
       
        public void checkIfEnable()
        {
            if (Card1.Enabled == true) c1 = 1; else c1 = 0;
            if (Duplicate1.Enabled == true) d1 = 1; else d1 = 0;
            if (Card2.Enabled ==true) c2 = 1; else c2 = 0;
            if (Duplicate2.Enabled == true) d2 = 1; else d2 = 0;
            if (Card3.Enabled == true) c3 = 1; else c3 = 0;
            if (Duplicate3.Enabled == true) d3 = 1; else d3 = 0;
            if (Card4.Enabled == true) c4 = 1; else c4 = 0;
            if (Duplicate4.Enabled == true) d4 = 1; else d4 = 0;
            if (Card5.Enabled == true) c5 = 1; else c5 = 0;
            if (Duplicate5.Enabled == true) d5 = 1; else d5 = 0;
            if (Card6.Enabled == true) c6 = 1; else c6 = 0;
            if (Duplicate6.Enabled == true) d6 = 1; else d6 = 0;
            if (Card7.Enabled == true) c7 = 1; else c7 = 0;
            if (Duplicate7.Enabled == true) d7 = 1; else d7 = 0;
            if (Card8.Enabled == true) c8 = 1; else c8 = 0;
            if (Duplicate8.Enabled == true) d8 = 1; else d8 = 0;
        }
        void recover()
        {
            if (c1 == 1) Card1.Enabled = true;
            if (d1 == 1) Duplicate1.Enabled = true;
            if (c2 == 1) Card2.Enabled = true;
            if (d2 == 1) Duplicate2.Enabled = true;
            if (c3 == 1) Card3.Enabled = true;
            if (d3 == 1) Duplicate3.Enabled = true;
            if (c4 == 1) Card4.Enabled = true;
            if (d4 == 1) Duplicate4.Enabled = true;
            if (c5 == 1) Card5.Enabled = true;
            if (d5 == 1) Duplicate5.Enabled = true;
            if (c6 == 1) Card6.Enabled = true;
            if (d6 == 1) Duplicate6.Enabled = true;
            if (c7 == 1) Card7.Enabled = true;
            if (d7 == 1) Duplicate7.Enabled = true;
            if (c8 == 1) Card8.Enabled = true; 
            if (d8 == 1) Duplicate8.Enabled = true;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2();
            Form2.Closed += (s, args) => this.Close();
            Form2.Show();
        }
    }
}
