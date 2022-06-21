using ProjectFloopyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFloopyBird
{
    public partial class Form1 : Form
    {

        bool isgameoverr;
        int pipespeed = 8;
        int gravity = 5;
        int score = 0;
        int highscore = 0;
        string un;
        Form2 form = new Form2();

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string u)
        {
            InitializeComponent();
            un = u;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            lowerblock.Left -= pipespeed; // it means that lower block will move left with the pipe speed
            Uperblock.Left -= pipespeed; // it means uper block will move left with pipe speed;
            label1.Text = score.ToString();
            if (lowerblock.Left < -50)     // these lower two funtions means if the lower block goes left side create another lower block , it helps creating loop of pipes or blocks 
            {
                lowerblock.Left = 600;
                score++;
            }

            if (Uperblock.Left < -80)
            {
                Uperblock.Left = 700;
                score++;
            }

            if (score > 10)
            {
                pipespeed = 15;
            }

            if (score > 5)
            {
                pipespeed = 10;
            }

            if (bird.Bounds.IntersectsWith(Uperblock.Bounds) ||
                bird.Bounds.IntersectsWith(lowerblock.Bounds)
                    || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                saveScore(score);
                endthegame();
                
                isgameoverr = true;
            }

            if (bird.Top < -25)
            {
                saveScore(score);
                endthegame();
                isgameoverr = true;
            }

            if (score == 12)
            {
                gametimer.Stop();
                MessageBox.Show("Congrats your on to the next level" +
                    "Press Enter to start New level");

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
        // this code will reset everything if pressed enter after lossing the game
        private void resetthegamee()
        {

            pipespeed = 8;
            gravity = 5;
            score = 0;
            isgameoverr = false;
            bird.Left = 24;
            bird.Top = 110;
            Uperblock.Left = 557;
            Uperblock.Top = -17;
            lowerblock.Left = 402;
            lowerblock.Top = 295;
            gametimer.Start();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -5;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                gravity = 5;
            }

            if (e.KeyCode == Keys.Enter && isgameoverr == true)
            {
                resetthegamee();
            }

            //if (e.KeyCode == Keys.Enter && score == 100 && isgameoverr == true)
            //{
            //    Form2 form2 = new Form2();
            //    form2.Show();
            //    this.Hide();
            //}
        }
        private void endthegame()
        {
            gametimer.Stop();
            MessageBox.Show("Game over. Your Score is " + score);

            isgameoverr = true;
        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        public void saveScore(int s)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=FlapppyBird;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update Player SET Score = @p_score where PlayerName = @p_name", con);
            cmd.Parameters.AddWithValue("p_score", s);
            cmd.Parameters.AddWithValue("p_name", un);
            cmd.ExecuteNonQuery();
        }
    }
}
