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
    public partial class Register : Form
    {   //MySql access for database
        private string cs = "server=localhost;userid=root;password='';database=icamper";
        MySqlConnection conn = null;
        MySqlDataReader reader = null;

        public Register()
        {
            InitializeComponent();
            Text = "Register"; //This is what link the HomePage register button with this Register form
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {   //Save the camper data into table camper in mysql database, take the input from the register textboxes
            String sql = "INSERT INTO camper(FNAME,NNAME,BUNK,AGE,NATIONALITY,RESTRICTION,START_DATE,LEAVE_DATE,TRANSPORTATION,PNAME,PHONE,EMAIL,PPNAME,PPHONE,PEMAIL) VALUES('"
                +this.camperName.Text+"','"+this.camperNickname.Text+"','"+this.camperBunk.Text+"','"+this.camperAge.Text+"','"+this.camperNationality.Text+"','"+this.camperRestriction.Text
                +"','"+this.camperStartdate.Text+"','"+this.camperLeavedate.Text+"','"+this.camperTransportation.Text+"','"+this.parent1Name.Text+"','"+this.parent1No.Text+"','"
                +this.parent1Email.Text+"','"+this.parent2Name.Text+"','"+this.parent2No.Text+"','"+this.parent2Email.Text+"')";

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

        private void New_Click(object sender, EventArgs e)
        {
            //Save sesion data into table camper database, take the input from combobox, new session can be save
            String sql = "INSERT INTO camper(CSESSION) VALUES('" + this.Session.Text + "')";
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

        private void Session_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Display of the registered session from HomePage
        }
    }
}
