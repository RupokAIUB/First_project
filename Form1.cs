using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values (@ID,@Name,@Semester)",con);
            cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",textBox2.Text);
            cmd.Parameters.AddWithValue("@Semester",double.Parse (textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set Name=@Name,Semester=@Semester where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Semester", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from ut where ID=@ID",con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
