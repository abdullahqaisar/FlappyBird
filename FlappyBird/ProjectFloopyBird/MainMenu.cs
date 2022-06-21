
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectFloopyBird
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=FlapppyBird;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Player where PlayerName = @p_name and Pass = @p_pass",  con);
            cmd.Parameters.AddWithValue("p_name", name);
            cmd.Parameters.AddWithValue("p_pass", password);
            SqlDataReader dr;
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                dr.Close();
                Form1 form1 = new Form1(name);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User does not Exist");
            }
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show();
            this.Hide();
        }
    }
}
