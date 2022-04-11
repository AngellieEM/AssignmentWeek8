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

namespace AssignmentWeek8
{
    public partial class FormHasilPertandingan : Form
    {
        public FormHasilPertandingan()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormHasilPertandingan_Load(object sender, EventArgs e)
        {
            DataTable dtTimHome = new DataTable();
            sqlQuery = "SELECT team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTimHome);
            

            DataTable dtTimLuar = new DataTable();
            sqlQuery = "SELECT team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTimLuar);

            cBTimHome.DataSource = dtTimHome;
            cBTimHome.DisplayMember = "Nama Tim";
            cBTimHome.ValueMember = "team_name";

            cBTimLuar.DataSource = dtTimLuar;
            cBTimLuar.DisplayMember = "Nama Tim";
            cBTimLuar.ValueMember = "team_name";
         
        }

        private void cBTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //datatable Stadium Tim Home
                DataTable dtTimHomeDetailStadium = new DataTable();
                sqlQuery = "SELECT CONCAT(home_stadium, ' , ',city) FROM team  WHERE team_name = '" + cBTimHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimHomeDetailStadium);
                
                lblStadiumTHomeHasil.Text = dtTimHomeDetailStadium.Rows[0][0].ToString();

                //datateble Capacity Tim Home
                DataTable dtTimHomeDetailCapacity = new DataTable();
                sqlQuery = "SELECT t.capacity FROM team t WHERE team_name = '" + cBTimHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimHomeDetailCapacity);

                lblCapacityTHomeHasil.Text = dtTimHomeDetailCapacity.Rows[0][0].ToString();

                //datatable Manager Tim Home
                DataTable dtTimHomeDetailManager = new DataTable();
                sqlQuery = "SELECT m.manager_name FROM team t, manager m WHERE t.manager_id = m.manager_id AND team_name = '" + cBTimHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimHomeDetailManager);

                lblManagerTHomeHasil.Text = dtTimHomeDetailManager.Rows[0][0].ToString();

                //datatable Captain Tim Home
                DataTable dtTimHomeDetailCaptain = new DataTable();
                sqlQuery = "SELECT p.player_name FROM team t, player p WHERE t.captain_id = p.player_id AND team_name = '" + cBTimHome.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimHomeDetailCaptain);

                lblCaptainTHomeHasil.Text = dtTimHomeDetailCaptain.Rows[0][0].ToString();

            }
            catch (Exception)
            {

                
            }
        }

        private void cBTimLuar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //datatable Manager Tim Luar
                DataTable dtTimLuarDetailManager = new DataTable();
                sqlQuery = "SELECT m.manager_name FROM team t, manager m WHERE t.manager_id = m.manager_id AND team_name = '" + cBTimLuar.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimLuarDetailManager);

                lblManagerTLuarHasil.Text = dtTimLuarDetailManager.Rows[0][0].ToString();

                //datatable Captain Tim Luar
                DataTable dtTimLuarDetailCaptain = new DataTable();
                sqlQuery = "SELECT p.player_name FROM team t, player p WHERE t.captain_id = p.player_id AND team_name = '" + cBTimLuar.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTimLuarDetailCaptain);

                lblCaptainTLuarHasil.Text = dtTimLuarDetailCaptain.Rows[0][0].ToString();

            }
            catch (Exception)
            {


            }
        }
    }
}
