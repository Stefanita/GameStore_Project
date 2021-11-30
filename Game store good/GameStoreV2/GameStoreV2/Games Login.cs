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
    public partial class FormGamesLogin : Form
    {
        //Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True
        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True");
        public FormGamesLogin()
        {
         
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStoteLogin newForm = new FormStoteLogin();
           newForm.ShowDialog(this);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FormCart newForm = new FormCart();
            newForm.ShowDialog(this);
        }

        private void FormGamesLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStoreV2DataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStoreV2DataSet.Games);
            // TODO: This line of code loads data into the 'gameStoreV2DataSet.Games' table. You can move, or remove it, as needed.
            // this.gamesTableAdapter.Fill(this.gameStoreV2DataSet.Games);

        }

        private void btnAddtocart_MouseClick(object sender, MouseEventArgs e)
        {
            //string game_name = dataGridView1.(sender)+"";

            try
            {
                //con.Open();
               // SqlCommand cmd = con.CreateCommand();
               // cmd.CommandType = CommandType.Text;
               // cmd.CommandText = "insert into Cart () values('" + "s" + "')";
              //  cmd.ExecuteNonQuery();
                //con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddons newForm = new FormAddons();
            newForm.ShowDialog(this);
        }
    }
}
