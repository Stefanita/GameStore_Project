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

namespace GameStoreV2
{
    public partial class SearchForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True");
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStoteLogin newForm = new FormStoteLogin();
            newForm.ShowDialog(this);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStoreV2DataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStoreV2DataSet.Games);
            // TODO: This line of code loads data into the 'gameStoreV2DataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStoreV2DataSet.Games);

        }

        
        


        private void btnSearch_Click(object sender, EventArgs e)
        {

            string Search = SearchtextBox.Text;
            string query = "select count(*) from Games where Game_Name='" + Search + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("The Game is in the store");
            }
            else
            {
                string text = "The game does not exist in the store";
                MessageBox.Show(text);
            }

            SearchtextBox.Clear();
        }

    }
}
