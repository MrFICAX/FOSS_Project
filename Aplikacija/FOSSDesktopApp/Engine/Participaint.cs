using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Engine
{
    public abstract class Participaint
    {
        private string name;
        private string surname;

        public Participaint()
        {

        }

        public Participaint(string name, string sur)
        {
            this.name = name;
            surname = sur;
        }

        public string PersonName 
        { 
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

    }
}
