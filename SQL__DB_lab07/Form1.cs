using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace SQL__DB_lab07
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapterBuildings = null;
        private SqlDataAdapter adapterApartments = null;
        private SqlDataAdapter adapterPrivatization = null;

        private DataTable tableBuildings = null;
        private DataTable tableApartments = null;
        private DataTable tablePrivatization = null;
        private DataTable tableReq = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            tableBuildings.Clear();
            tableApartments.Clear();
            tablePrivatization.Clear();

            adapterBuildings.Fill(tableBuildings);
            adapterApartments.Fill(tableApartments);
            adapterPrivatization.Fill(tablePrivatization);

            dataGridView1.DataSource = tableApartments;
            dataGridView2.DataSource = tableBuildings;
            dataGridView3.DataSource = tablePrivatization;
        }

        public void execute(string query, string message)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show($"Data {message} error", "Error");
                else
                    MessageBox.Show($"Data {message} success", "Success");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                update();
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button_load_build_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button_load_priv_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null ||
                dataGridView1.Rows[index].Cells[8].Value == null
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string flat = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string storey = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string rooms = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string squareflat = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string dwell = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string branch = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string balcony = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string height = dataGridView1.Rows[index].Cells[7].Value.ToString();
            string adr = dataGridView1.Rows[index].Cells[8].Value.ToString();



            string query = $"INSERT INTO APARTMENTS VALUES({flat}, {storey}, {rooms}, {squareflat}, {dwell}, {branch}, {balcony}, {height}, '{adr}')";
            execute(query, "add");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;


            string flat = dataGridView1.Rows[index].Cells[0].Value.ToString();



            string query = $"DELETE FROM APARTMENTS WHERE FLAT = {flat}";
            execute(query, "remove");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null ||
                dataGridView1.Rows[index].Cells[8].Value == null
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string flat = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string storey = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string rooms = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string squareflat = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string dwell = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string branch = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string balcony = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string height = dataGridView1.Rows[index].Cells[7].Value.ToString();
            string adr = dataGridView1.Rows[index].Cells[8].Value.ToString();



            string query = $"UPDATE APARTMENTS SET STOREY = {storey}, ROOMS = {rooms}, SQUAREFLAT = {squareflat}, DWELL = {dwell}, BRANCH = {branch}, BALCONY = {balcony}, HEIGHT = {height}, ADDRESSES  = '{adr}' WHERE FLAT = {flat}";
            execute(query, "update");
        }

        private void button_add_build_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null ||
                dataGridView2.Rows[index].Cells[6].Value == null ||
                dataGridView2.Rows[index].Cells[7].Value == null ||
                dataGridView2.Rows[index].Cells[8].Value == null ||
                dataGridView2.Rows[index].Cells[9].Value == null ||
                dataGridView2.Rows[index].Cells[10].Value == null
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string adr = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string dist = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string balance = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string years = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string material = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string bases = dataGridView2.Rows[index].Cells[5].Value.ToString();
            string wear = dataGridView2.Rows[index].Cells[6].Value.ToString();
            string flow = dataGridView2.Rows[index].Cells[7].Value.ToString();
            string line = dataGridView2.Rows[index].Cells[8].Value.ToString();
            string squares = dataGridView2.Rows[index].Cells[9].Value.ToString();
            string flat = dataGridView2.Rows[index].Cells[10].Value.ToString();

            string query = $"INSERT INTO BUILDINGS VALUES('{adr}', '{dist}', '{balance}', {years}, '{material}', '{bases}', {wear}, {flow}, {line}, {squares}, {flat})";
            execute(query, "add");
        }

        private void button_remove_build_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;


            string adr = dataGridView2.Rows[index].Cells[0].Value.ToString();



            string query = $"DELETE FROM BUILDINGS WHERE ADRESSES = '{adr}'";
            execute(query, "remove");
        }

        private void button_update_build_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView2.SelectedRows[0].Index;
            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null ||
                dataGridView2.Rows[index].Cells[5].Value == null ||
                dataGridView2.Rows[index].Cells[6].Value == null ||
                dataGridView2.Rows[index].Cells[7].Value == null ||
                dataGridView2.Rows[index].Cells[8].Value == null ||
                dataGridView2.Rows[index].Cells[9].Value == null ||
                dataGridView2.Rows[index].Cells[10].Value == null
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string adr = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string dist = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string balance = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string years = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string material = dataGridView2.Rows[index].Cells[4].Value.ToString();
            string bases = dataGridView2.Rows[index].Cells[5].Value.ToString();
            string wear = dataGridView2.Rows[index].Cells[6].Value.ToString();
            string flow = dataGridView2.Rows[index].Cells[7].Value.ToString();
            string line = dataGridView2.Rows[index].Cells[8].Value.ToString();
            string squares = dataGridView2.Rows[index].Cells[9].Value.ToString();
            string flat = dataGridView2.Rows[index].Cells[10].Value.ToString();


            string query = $"UPDATE BULDINGS SET DISTRICT = '{dist}', BALANCE = '{balance}', YEARS = {years}, MATERIAL = '{material}', BASE = '{bases}', WEAR = {wear}, FLOW = {flow}, LINE = {line}, SQUARES = {squares}, FLAT = {flat} WHERE ADRESSES = '{adr}'";
            execute(query, "update");
        }

        private void button_add_priv_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;
            if (dataGridView3.Rows[index].Cells[0].Value == null ||
                dataGridView3.Rows[index].Cells[1].Value == null ||
                dataGridView3.Rows[index].Cells[2].Value == null ||
                dataGridView3.Rows[index].Cells[3].Value == null ||
                dataGridView3.Rows[index].Cells[4].Value == null ||
                dataGridView3.Rows[index].Cells[5].Value == null ||
                dataGridView3.Rows[index].Cells[6].Value == null ||
                dataGridView3.Rows[index].Cells[7].Value == null ||
                dataGridView3.Rows[index].Cells[8].Value == null ||
                dataGridView3.Rows[index].Cells[9].Value == null
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string record = dataGridView3.Rows[index].Cells[0].Value.ToString();
            string document = dataGridView3.Rows[index].Cells[1].Value.ToString();
            string datedoc = dataGridView3.Rows[index].Cells[2].Value.ToString();
            string cost = dataGridView3.Rows[index].Cells[3].Value.ToString();
            string fiohost = dataGridView3.Rows[index].Cells[4].Value.ToString();
            string passport = dataGridView3.Rows[index].Cells[5].Value.ToString();
            string sing = dataGridView3.Rows[index].Cells[6].Value.ToString();
            string born = dataGridView3.Rows[index].Cells[7].Value.ToString();
            string statuses = dataGridView3.Rows[index].Cells[8].Value.ToString();
            string flat = dataGridView3.Rows[index].Cells[9].Value.ToString();
 

            string query = $"INSERT INTO PRIVATIZATION VALUES({record}, '{document}', '{datedoc}', {cost}, '{fiohost}', '{passport}', {sing}, {born}, '{statuses}', {flat})";
            execute(query, "add");
        }

        private void button_remove_priv_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;

            string record = dataGridView3.Rows[index].Cells[0].Value.ToString();

            string query = $"DELETE FROM PRIVATIZATION WHERE RECORD = {record}";
            execute(query, "remove");
        }

        private void button_update_priv_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 1)
            {
                MessageBox.Show("Choose 1 line", "Error");
                return;
            }

            int index = dataGridView3.SelectedRows[0].Index;
            if (dataGridView3.Rows[index].Cells[0].Value == null ||
                dataGridView3.Rows[index].Cells[1].Value == null ||
                dataGridView3.Rows[index].Cells[2].Value == null ||
                dataGridView3.Rows[index].Cells[3].Value == null ||
                dataGridView3.Rows[index].Cells[4].Value == null ||
                dataGridView3.Rows[index].Cells[5].Value == null ||
                dataGridView3.Rows[index].Cells[6].Value == null ||
                dataGridView3.Rows[index].Cells[7].Value == null ||
                dataGridView3.Rows[index].Cells[8].Value == null ||
                dataGridView3.Rows[index].Cells[9].Value == null 
                )
            {
                MessageBox.Show("Enter all columns", "Error");
                return;
            }

            string record = dataGridView3.Rows[index].Cells[0].Value.ToString();
            string document = dataGridView3.Rows[index].Cells[1].Value.ToString();
            string datedoc = dataGridView3.Rows[index].Cells[2].Value.ToString();
            string cost = dataGridView3.Rows[index].Cells[3].Value.ToString();
            string fiohost = dataGridView3.Rows[index].Cells[4].Value.ToString();
            string passport = dataGridView3.Rows[index].Cells[5].Value.ToString();
            string sing = dataGridView3.Rows[index].Cells[6].Value.ToString();
            string born = dataGridView3.Rows[index].Cells[7].Value.ToString();
            string statuses = dataGridView3.Rows[index].Cells[8].Value.ToString();
            string flat = dataGridView3.Rows[index].Cells[9].Value.ToString();

            string query = $"UPDATE PRIVATIZATION SET DOCUMENT = '{document}', DATEDOC = '{datedoc}', COST = {cost}, FIOHOST = '{fiohost}', PASSPORT = '{passport}', SING  = {sing}, BORN  = {born}, STATUSES = '{statuses}', FLAT = {flat} WHERE RECORD = {record}";
            execute(query, "update");
        }

        private void button_request1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM BUILDINGS WHERE YEAR > 1990", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView7.DataSource = tableReq;
        }

        private void button_request2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM APARTMENTS WHERE STOREY BETWEEN 2 AND 3", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView7.DataSource = tableReq;
        }

        private void button_request3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterCapacityMore = new SqlDataAdapter("SELECT * FROM PRIVATIZATION WHERE FLAT IN (101, 103)", sqlConnection);

            tableReq.Clear();
            adapterCapacityMore.Fill(tableReq);

            dataGridView7.DataSource = tableReq;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-169M10T\SQLEXPRESS;Initial Catalog=Housing;Integrated Security=True");

            sqlConnection.Open();

            adapterBuildings = new SqlDataAdapter("SELECT * FROM BUILDINGS", sqlConnection);
            adapterApartments = new SqlDataAdapter("SELECT * FROM APARTMENTS", sqlConnection);
            adapterPrivatization = new SqlDataAdapter("SELECT * FROM PRIVATIZATION", sqlConnection);

            tableBuildings = new DataTable();
            tableApartments = new DataTable();
            tablePrivatization = new DataTable();
            tableReq = new DataTable();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}