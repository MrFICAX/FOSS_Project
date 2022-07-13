using FOSSDesktopApp.Controllers.Interfaces;
using FOSSDesktopApp.Engine;
using FOSSDesktopApp.Forms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOSSDesktopApp.Controllers
{
    class RefereeController : IRefereeController
    {
        private IRefereeWindow refereeWindow;
        private RefereeList refereeList; 
        int initialQuality = 8; //OVU VREDNOST MOZEMO DA PROMENIMO

        RefereeList RefereeList 
        {
            get => this.refereeList;
            set => this.refereeList = value; 
        }

        public RefereeController(IRefereeWindow refereeWindow)
        {
            this.refereeWindow = refereeWindow;
            RefereeList = new RefereeList();
            GetRefereeList();
        }

        private void GetRefereeList()
        {
            if(RefereeList.LoadFromDB().Result) //OVO NEMAMO IMPLEMENTIRANO
                this.refereeWindow.SetDgwRefereeList(this.RefereeList.Referees);
        }

        public void AddNewReferee(string refereeName, string refereeSurname, int refereeQuality)
        {           
            Referee newReferee = new Referee(refereeName, refereeSurname, refereeQuality);

            if (SaveRefereeToDB(newReferee))
            {
                RefereeList.Add(newReferee);
                this.refereeWindow.SetDgwRefereeList(RefereeList.Referees);
            }
            else
            {
                MessageBox.Show("Sudija sa ovim registarskim brojem vec postoji!");
            }
        }

        private bool SaveRefereeToDB(Referee referee)
        {

            if (referee.SaveToDB().Result)
                return true;
            else
                return false;

            //return true; //OVO OBRISATI KADA SE RADI SA BAZOM
        }

    }
}
