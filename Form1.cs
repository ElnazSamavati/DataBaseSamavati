using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DB_ElnazSamavati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Tname = textBox3.Text;
            String TN_code = textBox2.Text;
            String Tmobile = textBox1.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\DB_ElnazSamavati\DB_ElnazSamavati\Database1.mdf;Integrated Security=True");
            sc.Open();
            String query = "INSERT INTO Teacher (name,N_code,Mobile) VALUES ('"+ Tname +"','"+ TN_code +"','"+ Tmobile +"')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Done");
            textBox3.Text = textBox2.Text = textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Sname = textBox7.Text;
            String S_code = textBox6.Text;
            String SN_code = textBox5.Text;
            String Smobile = textBox4.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\DB_ElnazSamavati\DB_ElnazSamavati\Database1.mdf;Integrated Security=True");
            sc.Open();
            String query = "INSERT INTO Student (name,N_code,Mobile,Student_code) VALUES ('" + Sname + "','" + SN_code + "','" + Smobile + "', '"+ S_code +"')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Done");
            textBox7.Text = textBox6.Text = textBox5.Text = textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\DB_ElnazSamavati\DB_ElnazSamavati\Database1.mdf;Integrated Security=True");
            sc.Open();
            String query = "SELECT name FROM Teacher";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                comboBox1.Items.Add(name);
            }
            sc.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Smobile = textBox4.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\DB_ElnazSamavati\DB_ElnazSamavati\Database1.mdf;Integrated Security=True");
            sc.Open();
            String query = "UPDATE Student SET = '"+ Smobile +"'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Change");
        }
    }
}