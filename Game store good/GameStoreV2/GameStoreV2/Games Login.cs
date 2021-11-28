using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreV2
{
    public partial class FormGamesLogin : Form
    {
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
    }
}
