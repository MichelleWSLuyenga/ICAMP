using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hades
{
    public partial class RegisterActivities : Form
    {
        private string cs = "server=localhost;userid=root;password='';database=icamper";
        MySqlConnection conn = null;
        MySqlDataReader reader = null;

        public RegisterActivities()
        {
            InitializeComponent();
            Text = "RegisterActivities";
        }

        private void RegisterActivities_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            //To check whether which subject group the subject belong to
           switch(subjects.SelectedItem.ToString().Trim())
            {
                case "Subject1":
                    listBox1.Items.Add(subjectName.Text);
                    break;
                case "Subject2":
                    listBox2.Items.Add(subjectName.Text);
                    break;
                case "Subject3":
                    listBox3.Items.Add(subjectName.Text);
                    break;
                case "Subject4":
                    listBox4.Items.Add(subjectName.Text);
                    break;
                case "Subject5":
                    listBox5.Items.Add(subjectName.Text);
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO regact(CDATE,SUB1,SUB2,SUB3,SUB4,SUB5) VALUES('" + this.dateRA.Value.Date.ToString() + "','" + this.listBox1.Text + "','" + this.listBox2.Text
                + "','" + this.listBox3.Text + "','" + this.listBox4.Text + "','" + this.listBox5.Text + "')";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
