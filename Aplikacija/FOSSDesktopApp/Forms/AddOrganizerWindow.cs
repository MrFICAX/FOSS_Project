using FOSSDesktopApp.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Forms
{
    public partial class AddOrganizerWindow : Form
    {
        #region Attributes

        private string inputName;
        private string inputSurname;
        private string inputUsername;
        private string inputPassword;
        private string inputConfirmPassword;

        #endregion

        #region Properties

        public string InputName { get => tbxName.Text; set => inputName = value; }
        public string InputSurname { get => tbxSurname.Text; set => inputSurname = value; }
        public string InputUsername { get => tbxInputUsername.Text; set => inputUsername = value; }
        public string InputPassword { get => tbxInputPassword.Text; set => tbxInputPassword.Text = value; }
        public string InputConfirmPassword { get => tbxInputConfirmPassword.Text; set => tbxInputConfirmPassword.Text = value; }

        #endregion

        #region Constructors

        public AddOrganizerWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Validation

        private bool ValidateInput()
        {
            if (String.IsNullOrEmpty(InputName) == true || String.IsNullOrEmpty(InputSurname) == true || String.IsNullOrEmpty(InputUsername) == true || String.IsNullOrEmpty(InputPassword) == true || String.IsNullOrEmpty(InputConfirmPassword) == true)
            {
                MessageBox.Show("Niste popunili sva predvidjena polja!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!String.Equals(InputPassword, InputConfirmPassword))
            {
                InputPassword = "";
                InputConfirmPassword = "";
                MessageBox.Show("Ne poklapaju Vam se unete vrednosti za password i potvrdu passworda!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            return true;
        }

        #endregion

        #region EventHandlers

        private void btnAddNewOrganizer_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            Organizer newOrganizer = new Organizer(this.InputName, this.InputSurname, this.InputUsername, this.InputPassword);
            if(newOrganizer.SaveToDB().Result)
            {
                MessageBox.Show("Uspesno ste dodali novog organizatora!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Neuspesno dodavanje novog organizatora!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion
    }
}
