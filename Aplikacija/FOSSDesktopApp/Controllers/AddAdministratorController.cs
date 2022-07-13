using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class AddAdministratorController : IAddAdministratorController
    {
        #region Attributes

        private readonly AddAdministratorWindow addAdministratorWindow;
        private Organizer activeOrganizer;

        #endregion

        #region Properties

        public Organizer ActiveOrganizer
        {
            get { return this.activeOrganizer; }
            set { 
                this.activeOrganizer = value;
                this.addAdministratorWindow.SetDgwAdministrators(this.activeOrganizer.AdminList);
                this.addAdministratorWindow.InputComboBox(value.Events);
                }
        }

        #endregion

        #region Constructorss

        public AddAdministratorController(AddAdministratorWindow mn, Organizer activeOrganizer)
        {
            this.addAdministratorWindow = mn;
            ActiveOrganizer = activeOrganizer;
        }

        #endregion

        #region Validations

        private bool ValidateInput(string Name, string Surname, string Enterkey)
        {
            if (String.IsNullOrEmpty(Name) == true || String.IsNullOrEmpty(Surname) == true || String.IsNullOrEmpty(Enterkey) == true)
            {
                MessageBox.Show("Morate uneti sve parametre!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        #endregion

        #region Methods

        public void AddNewAdministrator()
        {
            string Name = addAdministratorWindow.AdministratorName;
            string Surname = addAdministratorWindow.AdministratorSurname;
            string Enterkey = addAdministratorWindow.AdministratorEnterkey;
            if (!ValidateInput(Name, Surname, Enterkey))
            {
                return;
            }
            else
            {
                Administrator administrator = new Administrator(Enterkey, Name, Surname, ActiveOrganizer.Username);
                if (SaveAdministratortoDB(administrator))
                {
                    this.ActiveOrganizer.AdminList.Add(administrator);
                    this.addAdministratorWindow.SetDgwAdministrators(this.ActiveOrganizer.AdminList);
                    this.addAdministratorWindow.ClearAdministratorControls();
                }
                else
                {
                    MessageBox.Show("NEUSPESNO DODAVANJE ADMINISTRATORA!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        

        private bool SaveAdministratortoDB(Administrator adm)
        {
            
            if(adm.SaveToDB().Result)
                return true;
            else
                return false;
            
            //return true; //OVO OBRISATI KADA SE RADI SA BAZOM
        }

        public void DeleteAdministrator(string selectedAdministrator)
        {
            Administrator administrator = this.ActiveOrganizer.FindAdmin(selectedAdministrator);
            if(administrator == null)
            {
                MessageBox.Show("ADMIN SA OVIM PODACIMA NE POSTOJI U LISTI!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (administrator.DeleteFromDB().Result)
                {
                    this.ActiveOrganizer.AdminList.Remove(administrator);
                    this.addAdministratorWindow.SetDgwAdministrators(this.ActiveOrganizer.AdminList);
                    this.addAdministratorWindow.ClearDgwAdministratorsCompetitionList();
                }
            }
        }

        public void SelectedAdministratorClicked(string selectedAdministrator)
        {
            Administrator administrator = this.ActiveOrganizer.FindAdmin(selectedAdministrator);
            if (administrator == null)
            {
                MessageBox.Show("ADMIN SA OVIM PODACIMA NE POSTOJI U LISTI!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.addAdministratorWindow.SetDgwAdministratorsCompetitionList(administrator.Competitions.EventList);
            }
        }

        public void AddCompetitionToAdministrator(string selectedAdministrator, string selectedCompetition)
        {
            Competition competitionFromAdminsCompetitionList;
            Administrator tmpAdministrator = this.ActiveOrganizer.FindAdmin(selectedAdministrator);
            Competition tmpCompetition = this.ActiveOrganizer.Events.findByname(selectedCompetition);
            if(tmpAdministrator != null && tmpCompetition != null)
            {
                competitionFromAdminsCompetitionList = tmpAdministrator.Competitions.findByname(tmpCompetition.Name);
                if (competitionFromAdminsCompetitionList == null)
                {
                    tmpAdministrator.Competitions.addEvent(tmpCompetition);

                    if (tmpAdministrator.UpdateCompetitionListtoDB(tmpCompetition).Result)
                    {
                        
                         this.addAdministratorWindow.SetDgwAdministratorsCompetitionList(tmpAdministrator.Competitions.EventList);
                    }
                    else
                    {
                        tmpAdministrator.Competitions.removeEvent(tmpCompetition);
                    }
                }
                else
                {
                    MessageBox.Show("ADMIN POSEDUJE OVU PRIVILEGIJU!", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }

        public void DeleteCompetitionOfAdministrator(string selectedAdministrator, string selectedCompetition)
        {
            Administrator tmpAdministrator = this.ActiveOrganizer.FindAdmin(selectedAdministrator);
            Competition tmpCompetition = this.ActiveOrganizer.Events.findByname(selectedCompetition);
            if (tmpAdministrator != null && tmpCompetition != null)
            {
                if(tmpAdministrator.UnAssignCompetitionFromDB(tmpCompetition).Result){
                    tmpAdministrator.Competitions.removeEvent(tmpCompetition);
                    this.addAdministratorWindow.SetDgwAdministratorsCompetitionList(tmpAdministrator.Competitions.EventList);
                }
                else
                {
                    MessageBox.Show("NE RADI KOMUNIKACIJA SA BAZOM!", "INFORMACIJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }
        }

        #endregion
    }
}
