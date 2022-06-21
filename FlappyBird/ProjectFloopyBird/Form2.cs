using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectFloopyBird.Properties
{
    public partial class Form2 : Form
    {
       
        bool goleft, goright, jumping, isgameover;
        int jumpspeed;
        int force;
        int score = 0;
        int birdspeed = 7;

        int horizantalspeed = 5;
        int verticlespeed = 5;

        int enemyonespeed = 4;
        int enemytwospeed = 3;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void gametimerevent(object sender, EventArgs e)
        {
            label1.Text = "Score" + score;
            bird.Top += jumpspeed;

            if (goleft == true)
            {
                bird.Left -= birdspeed;
            }

            if (goright==true)
            {
                bird.Left += birdspeed;
            }
            //if jumping is true the force will tell us how high the bird will jump

            if (jumping==true&&force<0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpspeed = -8;
                force -= 1;
            }
            else
            {
                jumpspeed = 14;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ground")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 12;
                       bird.Top = x.Top - bird.Height;
                        //this below code will  make the bird stick to the horizantally moving ground.
                        if((string)x.Name== "horizantalground2" && goleft==false || (string)x.Name == "horizantalground2" && goright == false)
                        {
                            bird.Left -= horizantalspeed;
                        }
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                if(x is PictureBox && x.Tag == "enemy")
                {
                    if (bird.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();
                        isgameover = true;
                        label1.Text = "Score" + score + ".  Killed!";
                    }
                }
            }

            

            horizantalground2.Left -= horizantalspeed;
            if (horizantalground2.Left < 0 || horizantalground2.Left + horizantalground2.Width > this.ClientSize.Width)
            {
                horizantalspeed = -horizantalspeed;
            }
            verticleground2.Top += verticlespeed;
            if (verticleground2.Top < 147 || verticleground2.Top > 441)
            {
                verticlespeed = -verticlespeed;
            }

            enemy1.Left -= enemyonespeed;
            if (enemy1.Left < pictureBox2.Left || enemy1.Left + enemy1.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyonespeed = -enemyonespeed;
            }


            enemy2.Left += enemytwospeed;
            if (enemy2.Left < pictureBox1.Left || enemy2.Left + enemy2.Width > pictureBox1.Left + pictureBox1.Width)
            {
                enemytwospeed = -enemytwospeed;
            }


            if (bird.Top+bird.Height  > this.ClientSize.Height+50)
            {
                label1.Text = "Score" + score +  "  You Fell To Your Death";
                gametimer.Stop();
                isgameover = true;

            }

            if (bird.Bounds.IntersectsWith(door.Bounds)&&score==16)
            {
                gametimer.Stop();
                isgameover = true;
                MessageBox.Show("You WIN");
                GameOver gameOver = new GameOver();
                gameOver.Show();
                this.Hide();
            }
            else
            {  
                label1.Text = "Score" + score + Environment.NewLine + "Collect All Coins";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter&& isgameover==true)
            {
                resetthegame();

            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            { 
                goleft = true;
            }
            if ( e.KeyCode==Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode==Keys.Up && jumping==false)
            {
                jumping = true;
            }
        

        }

        private void resetthegame()
        {
            // since coins will be erased or invisible when touched by the bird
            // this fucnciton will reset all the coins

            goleft = false;
            goright = false;
            jumping = false;
            isgameover = false;
            label1.Text = "Score :" + score;
            
          //  foreach (Control x in this.Controls)
            //{
              //  if (x is PictureBox && x.Tag == "coin")
              
                //{
                  //  x.Visible = true;
                //}
            //}
            bird.Left = 72;
            bird.Top = 491;
            enemy1.Left = 415;
            enemy1.Top = 434;
            enemy2.Left = 462;
            enemy2.Top = 236;
            horizantalground2.Left = 275;
            verticleground2.Top = 309;
            gametimer.Start();
        }
    }

}
