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
    {   //MySql access for database
        private string cs = "server=localhost;userid=root;password='';database=icamper";
        MySqlConnection conn = null;
        MySqlDataReader reader = null;

        public RegisterActivities()
        {
            InitializeComponent();
            Text = "RegisterActivities"; //This is what link the HomePage register activities button with this RegisterActivities form
        }

        private void RegisterActivities_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            //To check whether which subject group the subject belong to and add the input subject on it listbox
           switch(subjects.SelectedItem.ToString().Trim())
            {
                case "Subject1":
                    listBox1.Items.Add(subjectName.Text);
                    choice1();
                    break;
                case "Subject2":
                    listBox2.Items.Add(subjectName.Text);
                    choice2();
                    break;
                case "Subject3":
                    listBox3.Items.Add(subjectName.Text);
                    choice3();
                    break;
                case "Subject4":
                    listBox4.Items.Add(subjectName.Text);
                    choice4();
                    break;
                case "Subject5":
                    listBox5.Items.Add(subjectName.Text);
                    choice5();
                    break;
            }
        }
        //Choices method which use in add_Click
        private void choice1()
        {   //Save subject1 into it database
            String sql = "INSERT INTO regact(CDATE,SUB1) VALUES('" + this.dateRA.Value.ToShortDateString() + "','" + this.subjectName.Text + "')";
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
        //Choices method which use in add_Click
        private void choice2()
        {    //Save subject2 into it database
            String sql = "INSERT INTO regact(CDATE,SUB2) VALUES('" + this.dateRA.Value.ToShortDateString() + "','" + this.subjectName.Text + "')";
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
        //Choices method which use in add_Click
        private void choice3()
        {   // //Save subject3 into it database
            String sql = "INSERT INTO regact(CDATE,SUB3) VALUES('" + this.dateRA.Value.ToShortDateString() + "','" + this.subjectName.Text + "')";
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
        //Choices method which use in add_Click
        private void choice4()
        {   // //Save subject4 into it database
            String sql = "INSERT INTO regact(CDATE,SUB4) VALUES('" + this.dateRA.Value.ToShortDateString() + "','" + this.subjectName.Text + "')";
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
        //Choices method which use in add_Click
        private void choice5()
        {   // //Save subject5 into it database
            String sql = "INSERT INTO regact(CDATE,SUB5) VALUES('" + this.dateRA.Value.ToShortDateString() + "','" + this.subjectName.Text + "')";
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void del1_Click(object sender, EventArgs e)
        {
            //Delete the select subject on the listbox
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //Delete subject from MySql database
            String sql = "DELETE FROM regact WHERE SUB1= '" + this.subjectName.Text + "';";
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

        private void del2_Click(object sender, EventArgs e)
        {
            //Delete the select subject on the listbox
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            //Delete subject from MySql database
            String sql = "DELETE FROM regact WHERE SUB2= '" + this.subjectName.Text + "';";
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

        private void del3_Click(object sender, EventArgs e)
        {
            //Delete the select subject on the listbox
            listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            //Delete subject from MySql database
            String sql = "DELETE FROM regact WHERE SUB3= '" + this.subjectName.Text + "';";
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

        private void del4_Click(object sender, EventArgs e)
        {
            //Delete the select subject on the listbox
            listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            //Delete subject from MySql database
            String sql = "DELETE FROM regact WHERE SUB4= '" + this.subjectName.Text + "';";
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

        private void del5_Click(object sender, EventArgs e)
        {
            //Delete the select subject on the listbox
            listBox5.Items.RemoveAt(listBox5.SelectedIndex);
            //Delete subject from MySql database
            String sql = "DELETE FROM regact WHERE SUB5= '" + this.subjectName.Text + "';";
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
