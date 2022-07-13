using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOSSDesktopApp.Engine
{
    public class CompetitionList
    {
        private List<Competition> eventList;

        public CompetitionList()
        {
            eventList = new List<Competition>();
        }

        public CompetitionList(List<Competition> comp)
        {
            eventList = new List<Competition>();
            if(comp != null)
            {
                foreach(Competition tmpCompetition in comp)
                {
                    EventList.Add(new Competition(tmpCompetition.Name, tmpCompetition.Location, tmpCompetition.StartDate, tmpCompetition.TeamListList, tmpCompetition.MatchListList, tmpCompetition.TeamStatistics, tmpCompetition.PlayerStatistics));
                }
            }
                eventList = comp;
        }
        public void addEvent(Competition evnt)
        {
            eventList.Add(evnt);
        }

        public void removeEvent(Competition evnt)
        {
            eventList.Remove(evnt);
        }

        public List<Competition> EventList
        {
            get { return eventList; }
            set { this.eventList = value; }
        }

        public Competition findByname(string name)
        {
            return eventList.Where(el => el.Name == name).FirstOrDefault();
        }

        public Competition this[int index]
            {
                get { return eventList[index]; }
                set { eventList[index] = value; }
            }

    }
}
