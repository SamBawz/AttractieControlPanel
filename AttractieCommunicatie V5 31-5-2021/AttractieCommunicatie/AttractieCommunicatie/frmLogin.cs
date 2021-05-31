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
            Acount a = new Acount("Admin", "123");
            Acount b = new Acount("Admin2", "321");            

            List<Acount> acounts = new List<Acount>();
            acounts.Add(a);

            foreach(Acount acount in acounts)
            {
                if (txtGebruikersnaam.Text == acount.Name && txtWachtwoord.Text == acount.Password) 
                {
                    openForm();
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam of wachtwoord niet juist!");
                }
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
