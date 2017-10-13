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
    public partial class SelectActivities : Form
    {
        //MySql access for database
        private string cs = "server=localhost;userid=root;password='';database=icamper";
        MySqlConnection conn = null;
        MySqlDataReader reader = null;

        public SelectActivities()
        {
            InitializeComponent();
            Text = "SelectActivities"; //This is what link the HomePage choose activities button with this SelectActivities form
        }

        private void SelectActivities_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   //Suppose to shows the available list of activities on this listbox
            String sql = "SELECT SUB1 FROM regact;";
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

        private void bunks_SelectedIndexChanged(object sender, EventArgs e)
        {   //To display the bunk list on the combobox
            String sql = "SELECT bunk FROM camper";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                //MySqlCommand cmd = new MySqlCommand(sql, conn);
               /* reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunks.Items.Add(reader.GetString(0));
                }*/

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
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

        private void Save_Click(object sender, EventArgs e)
        {   //Save the choices of subjects for each camper into the database
            String sql = "INSERT INTO choices(BUNK,FNAME,CDATE,SUB1,SUB2,SUB3,SUB4,SUB5) VALUES('"
                + this.bunks.Items.ToString() + "','" + this.names.Items.ToString() + "','" + this.dateSA.Value.ToShortDateString() + "','" + this.listBox1.Items.ToString() 
                + "','" + this.listBox2.Items.ToString() + "','" + this.listBox3.Items.ToString() + "','" + this.listBox4.Items.ToString() + "'.'" + this.listBox5.Items.ToString() +"')";
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
