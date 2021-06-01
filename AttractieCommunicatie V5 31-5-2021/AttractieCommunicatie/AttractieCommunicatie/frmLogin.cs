using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttractieCommunicatie
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Account.logIn(txtGebruikersnaam.Text, txtWachtwoord.Text))
            {
                openForm();
            }
            else
            {
                MessageBox.Show("Uw gebruikersnaam of wachtwoord is verkeerd.");
            }
        }

        private void openForm()
        {
            frmControlPanel frmCtrl = new frmControlPanel();
            frmCtrl.Location = this.Location;
            frmCtrl.StartPosition = FormStartPosition.Manual;
            //When frmGame closes the main menu will open again
            frmCtrl.FormClosing += delegate { this.Show(); };
            frmCtrl.Show();
            this.Hide();
        }
    }
}
