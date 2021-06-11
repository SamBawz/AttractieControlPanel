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
            if(!Database.testConnection())
            {
                MessageBox.Show("Kan niet verbinden met de database.");
            }
            else if(Account.authenticate(txtGebruikersnaam.Text, txtWachtwoord.Text))
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

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pbQuickLogin_Click(object sender, EventArgs e)
        {
            //For when not wanting to type -only for devs-
            openForm();
        }
    }
}
