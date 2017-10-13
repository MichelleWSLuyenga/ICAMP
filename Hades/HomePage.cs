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
    public partial class HomePage : Form
    {   //MySql access for database
        private string cs = "server=localhost;userid=root;password='';database=icamper";
        MySqlConnection conn = null;
        MySqlDataReader reader = null;

        private Register reg = new Register();

        public static string SelectedItem;

        public HomePage()
        {
            InitializeComponent();
        }

        private void registerEdit_Click(object sender, EventArgs e)
        {   
            reg.Show(); //Link to the register form
            reg.Session.Text = sessions.Text; //Suppose to display session detail on Register form as well
        }

        private void chooseActivities_Click(object sender, EventArgs e)
        {
            SelectActivities sa = new SelectActivities();
            sa.Show(); //Link to the select activities form
        }

        private void registerActivities_Click(object sender, EventArgs e)
        {
            RegisterActivities ra = new RegisterActivities();
            ra.Show(); //Link to the register activities form
        }

        private void newSession_Click(object sender, EventArgs e)
        {
            //reg.sessionsgetset = ;
            // reg.ShowDialog();
            // sessions.Text = reg.Sessiongetset;

            //Save sesion data into table camper database, take the input from combobox
            String sql = "INSERT INTO camper(CSESSION) VALUES('"+this.sessions.Text+"')";
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

            this.sessions.Text = reg.Session.Text;
          
        }

        private void HomePage_Click(object sender, EventArgs e)
        {   //Suppose to change the background color
            this.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            /*foreach (Excel.Worksheet ws in wb.Worksheets)
            {
                Excel.PageSetup ps = (Excel.PageSetup)ws.PageSetup;
                ws.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
                ws.PageSetup.Order = Excel.XlOrder.xlDownThenOver;
                ws.PageSetup.FitToPagesWide = 1;
                ws.PageSetup.FitToPagesTall = 50;
                ws.PageSetup.Zoom = false;
            }
            wb.Worksheets.PrintOutEx();*/
        }
    }
}
