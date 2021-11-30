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
    public partial class FormSteam : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True");
        public FormSteam()
        {
            
            // this.gamesTableAdapter.Fill(this.gameStoreV2DataSet.Games);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = IDtextBox.Text;
            string query = "select count(*) from id where id='" + ID + "'";
            con.Open();
           SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {

                this.Hide();
                FormStoteLogin newForm = new FormStoteLogin();
                newForm.ShowDialog(this);
            }
            else
            {
                string text = "Wrong ID";
                MessageBox.Show(text);
            }

            IDtextBox.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSteam_Load(object sender, EventArgs e)
        {

        }
    }
}
