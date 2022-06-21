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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=ABDULLAH;Initial Catalog=FlapppyBird;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into [Player] Values (@p_name,  @p_pass, 0)", con);
            cmd.Parameters.AddWithValue("p_name", name);
            cmd.Parameters.AddWithValue("p_pass", password);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Account Created");
             
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
