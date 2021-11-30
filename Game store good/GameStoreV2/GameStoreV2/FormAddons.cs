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
    public partial class FormAddons : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TORO;Initial Catalog=GameStoreV2;Integrated Security=True");
        public FormAddons()
        {
          
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGamesLogin newForm = new FormGamesLogin();
            newForm.ShowDialog(this);
        }

        private void FormAddons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStoreV2DataSet1.Dlc' table. You can move, or remove it, as needed.
            this.dlcTableAdapter.Fill(this.gameStoreV2DataSet1.Dlc);

        }
    }
}
